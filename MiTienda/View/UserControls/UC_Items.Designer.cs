namespace MiTienda.View.UserControls
{
    partial class UC_Items
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Items));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerTipos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EllipbtnVertipos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEMS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnVerTipos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 41);
            this.panel1.TabIndex = 1;
            // 
            // btnVerTipos
            // 
            this.btnVerTipos.Activecolor = System.Drawing.Color.Teal;
            this.btnVerTipos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerTipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerTipos.BorderRadius = 0;
            this.btnVerTipos.ButtonText = "Ver tipos";
            this.btnVerTipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTipos.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTipos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerTipos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerTipos.Iconimage")));
            this.btnVerTipos.Iconimage_right = null;
            this.btnVerTipos.Iconimage_right_Selected = null;
            this.btnVerTipos.Iconimage_Selected = null;
            this.btnVerTipos.IconMarginLeft = 0;
            this.btnVerTipos.IconMarginRight = 0;
            this.btnVerTipos.IconRightVisible = true;
            this.btnVerTipos.IconRightZoom = 0D;
            this.btnVerTipos.IconVisible = true;
            this.btnVerTipos.IconZoom = 50D;
            this.btnVerTipos.IsTab = false;
            this.btnVerTipos.Location = new System.Drawing.Point(666, 4);
            this.btnVerTipos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerTipos.Name = "btnVerTipos";
            this.btnVerTipos.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnVerTipos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerTipos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerTipos.selected = false;
            this.btnVerTipos.Size = new System.Drawing.Size(108, 34);
            this.btnVerTipos.TabIndex = 2;
            this.btnVerTipos.Text = "Ver tipos";
            this.btnVerTipos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerTipos.Textcolor = System.Drawing.Color.White;
            this.btnVerTipos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTipos.Click += new System.EventHandler(this.btnVerTipos_Click);
            // 
            // EllipbtnVertipos
            // 
            this.EllipbtnVertipos.ElipseRadius = 30;
            this.EllipbtnVertipos.TargetControl = this.btnVerTipos;
            // 
            // UC_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Items";
            this.Size = new System.Drawing.Size(784, 597);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerTipos;
        private Bunifu.Framework.UI.BunifuElipse EllipbtnVertipos;
    }
}
