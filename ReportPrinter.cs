// In ReportPrinter.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public class ReportPrinter
    {
        private readonly DataTable _dataToPrint;
        private readonly List<string> _headers;
        private readonly List<float> _columnWidths;
        private readonly string _reportTitle;
        private readonly string _dateRange;
        private readonly Dictionary<string, string> _summary;
        private int _currentRowIndex;
        private int _pageNumber;

        public ReportPrinter(DataTable data, List<string> headers, List<float> widths, string title, string dateRange, Dictionary<string, string> summary)
        {
            _dataToPrint = data;
            _headers = headers;
            _columnWidths = widths;
            _reportTitle = title;
            _dateRange = dateRange;
            _summary = summary;
        }

        public void Print()
        {
            try
            {
                using (var pd = new PrintDocument())
                {
                    pd.BeginPrint += (s, e) => { _currentRowIndex = 0; _pageNumber = 1; };
                    pd.PrintPage += PrintPageHandler;
                    pd.DocumentName = _reportTitle;
                    pd.DefaultPageSettings.Landscape = true;
                    var preview = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
                    preview.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing failed: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private PaperSize FindPaperSize(PrinterSettings printerSettings, string paperName)
        {
            foreach (PaperSize ps in printerSettings.PaperSizes)
            {
                if (ps.PaperName.Equals(paperName, StringComparison.OrdinalIgnoreCase))
                {
                    return ps;
                }
            }
            return null; // Return null if not found, printer will use its default
        }
        public void Print(bool isLandscape, string paperName = "A4") // Default to A4
        {
            try
            {
                using (var pd = new PrintDocument())
                {
                    pd.BeginPrint += (s, e) => { _currentRowIndex = 0; _pageNumber = 1; };
                    pd.PrintPage += PrintPageHandler;
                    pd.DocumentName = _reportTitle;
                    pd.DefaultPageSettings.Landscape = isLandscape;

                    // --- NEW: Find and set the requested paper size ---
                    PaperSize pkSize = FindPaperSize(pd.PrinterSettings, paperName);
                    if (pkSize != null)
                    {
                        pd.DefaultPageSettings.PaperSize = pkSize;
                    }

                    var preview = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
                    preview.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing failed: " + ex.Message);
            }
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Font titleFont = new Font("Arial", 14, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 9, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 9))
            {
                RectangleF drawArea = e.MarginBounds;
                float yPos = drawArea.Top;
                float leftMargin = drawArea.Left;

                // --- Report Header ---
                g.DrawString(_reportTitle, titleFont, Brushes.Black, leftMargin, yPos);
                string pageText = $"Page {_pageNumber}";
                g.DrawString(pageText, bodyFont, Brushes.Gray, drawArea.Right - g.MeasureString(pageText, bodyFont).Width, yPos);
                yPos += titleFont.GetHeight(g) + 20;

                // --- Table Header ---
                float currentX = leftMargin;
                float rowHeight = headerFont.GetHeight(g) + 12;
                g.FillRectangle(Brushes.LightGray, leftMargin, yPos, drawArea.Width, rowHeight);
                for (int i = 0; i < _headers.Count; i++)
                {
                    g.DrawString(_headers[i], headerFont, Brushes.Black, new RectangleF(currentX + 5, yPos, (drawArea.Width * _columnWidths[i]) - 10, rowHeight), new StringFormat { LineAlignment = StringAlignment.Center });
                    currentX += drawArea.Width * _columnWidths[i];
                }
                yPos += rowHeight;

                // --- Table Rows & Pagination ---
                while (_currentRowIndex < _dataToPrint.Rows.Count)
                {
                    // Check if there is space on the page for the next line
                    if (yPos + rowHeight > drawArea.Bottom)
                    {
                        e.HasMorePages = false;
                        _pageNumber++;
                        return; // Stop this page and trigger the next one
                    }

                    DataRow row = _dataToPrint.Rows[_currentRowIndex];
                    currentX = leftMargin;
                    for (int i = 0; i < _headers.Count; i++)
                    {
                        string cellValue = row[i]?.ToString() ?? "";
                        g.DrawString(cellValue, bodyFont, Brushes.Black, new RectangleF(currentX + 5, yPos, (drawArea.Width * _columnWidths[i]) - 10, rowHeight), new StringFormat { LineAlignment = StringAlignment.Center });
                        currentX += drawArea.Width * _columnWidths[i];
                    }
                    yPos += rowHeight;
                    _currentRowIndex++;
                }

                // If we get here, it means all rows have been printed
                e.HasMorePages = false;
            }
        }
    }
}