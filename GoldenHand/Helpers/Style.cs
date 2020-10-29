using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenHand.Helpers
{
    public static class Style
    {
        public static void StyleDataGrid(DataGridView d)
        {
            d.EnableHeadersVisualStyles = false;
            d.ColumnHeadersHeight = 50;
            d.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            d.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            d.RowTemplate.Height = 28;
            d.AllowUserToResizeRows = false;
            d.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

            foreach (DataGridViewColumn c in d.Columns)
            {
                c.HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                c.HeaderCell.Style.BackColor = Color.NavajoWhite;
            }
        }
    }
}
