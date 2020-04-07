using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///Referencias
using MiTienda.View.UserControls;

namespace MiTienda
{
    public partial class Principal : Form
    {
        int panelWidth;
        bool isCollapsed;
        public Principal()
        {
            InitializeComponent();
            UC_Inicio uch = new UC_Inicio();
            panelWidth = pnlIzq.Width;
            isCollapsed = false;
            addControlsToPanel(uch);
        }

        private void moveSidePanel(Control btn)
        {
            panelAct.Top = btn.Top;
            panelAct.Height = btn.Height;
        }
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlCuerpo.Controls.Clear();
            pnlCuerpo.Controls.Add(c);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnInicio);
            UC_Inicio uch = new UC_Inicio();
            addControlsToPanel(uch);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnItems);
            UC_Items uch = new UC_Items();
            addControlsToPanel(uch);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlSIdebar.Visible = false;
                pnlIzq.Width = pnlIzq.Width + 20;
                if(pnlIzq.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                    trans1.Show(pnlSIdebar);
                }
            }
            else
            {
                pnlSIdebar.Visible = false;
                pnlIzq.Width = pnlIzq.Width - 20;
                if (pnlIzq.Width <= 80)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                    trans1.Show(pnlSIdebar);
                }
            }
        }
    }
}
