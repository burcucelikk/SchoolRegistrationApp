namespace SchoolRegistrationApp
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            o = new DevExpress.XtraBars.BarButtonItem();
            TUDENTS = new DevExpress.XtraBars.BarButtonItem();
            AC = new DevExpress.XtraBars.BarButtonItem();
            AVE = new DevExpress.XtraBars.BarButtonItem();
            ELETE = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            LCULATEO = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, o, TUDENTS, AC, AVE, ELETE, barButtonItem6, LCULATEO, barButtonItem8, barButtonItem1, barButtonItem2 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 11;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(832, 183);
            // 
            // o
            // 
            o.Caption = "HOME";
            o.Id = 1;
            o.ImageOptions.LargeImage = (Image)resources.GetObject("o.ImageOptions.LargeImage");
            o.Name = "o";
            // 
            // TUDENTS
            // 
            TUDENTS.Caption = "STUDENTS";
            TUDENTS.Id = 2;
            TUDENTS.ImageOptions.LargeImage = (Image)resources.GetObject("TUDENTS.ImageOptions.LargeImage");
            TUDENTS.Name = "TUDENTS";
            // 
            // AC
            // 
            AC.Caption = "TEACHERS";
            AC.Id = 3;
            AC.ImageOptions.LargeImage = (Image)resources.GetObject("AC.ImageOptions.LargeImage");
            AC.Name = "AC";
            // 
            // AVE
            // 
            AVE.Caption = "SAVE";
            AVE.Id = 4;
            AVE.ImageOptions.LargeImage = (Image)resources.GetObject("AVE.ImageOptions.LargeImage");
            AVE.Name = "AVE";
            // 
            // ELETE
            // 
            ELETE.Caption = "DELETE";
            ELETE.Id = 5;
            ELETE.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem5.ImageOptions.LargeImage");
            ELETE.Name = "ELETE";
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "UPDATE";
            barButtonItem6.Id = 6;
            barButtonItem6.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem6.ImageOptions.LargeImage");
            barButtonItem6.Name = "barButtonItem6";
            // 
            // LCULATEO
            // 
            LCULATEO.Caption = "CALCULATOR";
            LCULATEO.Id = 7;
            LCULATEO.ImageOptions.Image = (Image)resources.GetObject("barButtonItem7.ImageOptions.Image");
            LCULATEO.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem7.ImageOptions.LargeImage");
            LCULATEO.Name = "LCULATEO";
            // 
            // barButtonItem8
            // 
            barButtonItem8.Caption = "HELP";
            barButtonItem8.Id = 8;
            barButtonItem8.ImageOptions.Image = (Image)resources.GetObject("barButtonItem8.ImageOptions.Image");
            barButtonItem8.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem8.ImageOptions.LargeImage");
            barButtonItem8.Name = "barButtonItem8";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "OKUL KAYITLARI";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            ribbonPageGroup1.ItemLinks.Add(o);
            ribbonPageGroup1.ItemLinks.Add(TUDENTS, true);
            ribbonPageGroup1.ItemLinks.Add(AC, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2, true);
            ribbonPageGroup1.ItemLinks.Add(AVE, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem6, true);
            ribbonPageGroup1.ItemLinks.Add(ELETE, true);
            ribbonPageGroup1.ItemLinks.Add(LCULATEO, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem8, true);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "CLASSES";
            barButtonItem1.Id = 9;
            barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "GRADES";
            barButtonItem2.Id = 10;
            barButtonItem2.ImageOptions.Image = (Image)resources.GetObject("barButtonItem2.ImageOptions.Image");
            barButtonItem2.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem2.ImageOptions.LargeImage");
            barButtonItem2.Name = "barButtonItem2";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 523);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem o;
        private DevExpress.XtraBars.BarButtonItem TUDENTS;
        private DevExpress.XtraBars.BarButtonItem AC;
        private DevExpress.XtraBars.BarButtonItem AVE;
        private DevExpress.XtraBars.BarButtonItem ELETE;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem LCULATEO;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}