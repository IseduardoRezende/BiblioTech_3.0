using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0.Model
{
    public class Layout
    {
        public void DataGridViewLayout(DataGridView view)
        {
            view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view.AutoSize = true;
            view.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;                   
        }
    }
}
