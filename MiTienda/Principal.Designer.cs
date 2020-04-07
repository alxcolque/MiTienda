namespace MiTienda
{
    partial class Principal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlIzq = new System.Windows.Forms.Panel();
            this.pnlSIdebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGraficos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelAct = new System.Windows.Forms.Panel();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trans1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlSuperior.SuspendLayout();
            this.pnlIzq.SuspendLayout();
            this.pnlSIdebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.lblUser);
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Controls.Add(this.btnMenu);
            this.trans1.SetDecoration(this.pnlSuperior, BunifuAnimatorNS.DecorationType.None);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(984, 64);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pnlIzq
            // 
            this.pnlIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pnlIzq.Controls.Add(this.pnlSIdebar);
            this.trans1.SetDecoration(this.pnlIzq, BunifuAnimatorNS.DecorationType.None);
            this.pnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzq.Location = new System.Drawing.Point(0, 64);
            this.pnlIzq.Name = "pnlIzq";
            this.pnlIzq.Size = new System.Drawing.Size(200, 597);
            this.pnlIzq.TabIndex = 2;
            // 
            // pnlSIdebar
            // 
            this.pnlSIdebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSIdebar.BackgroundImage")));
            this.pnlSIdebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSIdebar.Controls.Add(this.panelAct);
            this.pnlSIdebar.Controls.Add(this.btnGraficos);
            this.pnlSIdebar.Controls.Add(this.btnClientes);
            this.pnlSIdebar.Controls.Add(this.btnVentas);
            this.pnlSIdebar.Controls.Add(this.btnStock);
            this.pnlSIdebar.Controls.Add(this.btnItems);
            this.pnlSIdebar.Controls.Add(this.btnInicio);
            this.trans1.SetDecoration(this.pnlSIdebar, BunifuAnimatorNS.DecorationType.None);
            this.pnlSIdebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlSIdebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlSIdebar.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnlSIdebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlSIdebar.Location = new System.Drawing.Point(12, 6);
            this.pnlSIdebar.Name = "pnlSIdebar";
            this.pnlSIdebar.Quality = 10;
            this.pnlSIdebar.Size = new System.Drawing.Size(175, 567);
            this.pnlSIdebar.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.trans1.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(166, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(34, 37);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.trans1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mi APP";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.trans1.SetDecoration(this.lblUser, BunifuAnimatorNS.DecorationType.None);
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUser.Location = new System.Drawing.Point(826, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 25);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.trans1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(920, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "INICIO";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInicio.Iconimage")));
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 50D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(3, 21);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(169, 50);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInicio.Textcolor = System.Drawing.Color.White;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnItems
            // 
            this.btnItems.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnItems.BackColor = System.Drawing.Color.Transparent;
            this.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItems.BorderRadius = 0;
            this.btnItems.ButtonText = "ITEMS";
            this.btnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.btnItems, BunifuAnimatorNS.DecorationType.None);
            this.btnItems.DisabledColor = System.Drawing.Color.Gray;
            this.btnItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnItems.Iconimage")));
            this.btnItems.Iconimage_right = null;
            this.btnItems.Iconimage_right_Selected = null;
            this.btnItems.Iconimage_Selected = null;
            this.btnItems.IconMarginLeft = 0;
            this.btnItems.IconMarginRight = 0;
            this.btnItems.IconRightVisible = true;
            this.btnItems.IconRightZoom = 0D;
            this.btnItems.IconVisible = true;
            this.btnItems.IconZoom = 50D;
            this.btnItems.IsTab = false;
            this.btnItems.Location = new System.Drawing.Point(3, 77);
            this.btnItems.Name = "btnItems";
            this.btnItems.Normalcolor = System.Drawing.Color.Transparent;
            this.btnItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnItems.selected = false;
            this.btnItems.Size = new System.Drawing.Size(169, 50);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "ITEMS";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItems.Textcolor = System.Drawing.Color.White;
            this.btnItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnStock
            // 
            this.btnStock.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStock.BorderRadius = 0;
            this.btnStock.ButtonText = "STOCK";
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.btnStock, BunifuAnimatorNS.DecorationType.None);
            this.btnStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStock.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStock.Iconimage")));
            this.btnStock.Iconimage_right = null;
            this.btnStock.Iconimage_right_Selected = null;
            this.btnStock.Iconimage_Selected = null;
            this.btnStock.IconMarginLeft = 0;
            this.btnStock.IconMarginRight = 0;
            this.btnStock.IconRightVisible = true;
            this.btnStock.IconRightZoom = 0D;
            this.btnStock.IconVisible = true;
            this.btnStock.IconZoom = 50D;
            this.btnStock.IsTab = false;
            this.btnStock.Location = new System.Drawing.Point(3, 133);
            this.btnStock.Name = "btnStock";
            this.btnStock.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStock.selected = false;
            this.btnStock.Size = new System.Drawing.Size(169, 50);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "STOCK";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStock.Textcolor = System.Drawing.Color.White;
            this.btnStock.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 50D;
            this.btnVentas.IsTab = false;
            this.btnVentas.Location = new System.Drawing.Point(3, 189);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(169, 50);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.Textcolor = System.Drawing.Color.White;
            this.btnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "CIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 50D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(3, 245);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(169, 50);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "CIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGraficos
            // 
            this.btnGraficos.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnGraficos.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraficos.BorderRadius = 0;
            this.btnGraficos.ButtonText = "GRAFICOS";
            this.btnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.btnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.btnGraficos.DisabledColor = System.Drawing.Color.Gray;
            this.btnGraficos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGraficos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGraficos.Iconimage")));
            this.btnGraficos.Iconimage_right = null;
            this.btnGraficos.Iconimage_right_Selected = null;
            this.btnGraficos.Iconimage_Selected = null;
            this.btnGraficos.IconMarginLeft = 0;
            this.btnGraficos.IconMarginRight = 0;
            this.btnGraficos.IconRightVisible = true;
            this.btnGraficos.IconRightZoom = 0D;
            this.btnGraficos.IconVisible = true;
            this.btnGraficos.IconZoom = 50D;
            this.btnGraficos.IsTab = false;
            this.btnGraficos.Location = new System.Drawing.Point(3, 301);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGraficos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnGraficos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGraficos.selected = false;
            this.btnGraficos.Size = new System.Drawing.Size(169, 50);
            this.btnGraficos.TabIndex = 5;
            this.btnGraficos.Text = "GRAFICOS";
            this.btnGraficos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGraficos.Textcolor = System.Drawing.Color.White;
            this.btnGraficos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelAct
            // 
            this.panelAct.BackColor = System.Drawing.Color.Lime;
            this.trans1.SetDecoration(this.panelAct, BunifuAnimatorNS.DecorationType.None);
            this.panelAct.Location = new System.Drawing.Point(3, 21);
            this.panelAct.Name = "panelAct";
            this.panelAct.Size = new System.Drawing.Size(12, 50);
            this.panelAct.TabIndex = 0;
            // 
            // pnlCuerpo
            // 
            this.trans1.SetDecoration(this.pnlCuerpo, BunifuAnimatorNS.DecorationType.None);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(200, 64);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(784, 597);
            this.pnlCuerpo.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trans1
            // 
            this.trans1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.trans1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.trans1.DefaultAnimation = animation1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlIzq);
            this.Controls.Add(this.pnlSuperior);
            this.trans1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlIzq.ResumeLayout(false);
            this.pnlSIdebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSIdebar;
        private System.Windows.Forms.Panel pnlIzq;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnGraficos;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnStock;
        private Bunifu.Framework.UI.BunifuFlatButton btnItems;
        private System.Windows.Forms.Panel panelAct;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Timer timer1;
        private BunifuAnimatorNS.BunifuTransition trans1;
    }
}