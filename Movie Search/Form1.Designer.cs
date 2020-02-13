namespace Movie_Search
{
    partial class MovieSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieSearch));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.exitbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.savebtn = new XanderUI.XUISuperButton();
            this.loadbtn = new XanderUI.XUISuperButton();
            this.runtime = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.genretext = new System.Windows.Forms.Label();
            this.titletext = new System.Windows.Forms.Label();
            this.searchbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.prevbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.nextbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gobtn = new XanderUI.XUISuperButton();
            this.label1 = new System.Windows.Forms.Label();
            this.posterimg = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterimg)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.header.Controls.Add(this.label6);
            this.header.Controls.Add(this.exitbtn);
            resources.ApplyResources(this.header, "header");
            this.header.Name = "header";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.exitbtn.Image = global::Movie_Search.Properties.Resources.icons8_xbox_x_80;
            this.exitbtn.ImageActive = null;
            resources.ApplyResources(this.exitbtn, "exitbtn");
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.TabStop = false;
            this.exitbtn.Zoom = 10;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.Controls.Add(this.savebtn);
            this.bunifuGradientPanel1.Controls.Add(this.loadbtn);
            this.bunifuGradientPanel1.Controls.Add(this.runtime);
            this.bunifuGradientPanel1.Controls.Add(this.year);
            this.bunifuGradientPanel1.Controls.Add(this.genretext);
            this.bunifuGradientPanel1.Controls.Add(this.titletext);
            this.bunifuGradientPanel1.Controls.Add(this.searchbox);
            this.bunifuGradientPanel1.Controls.Add(this.prevbtn);
            this.bunifuGradientPanel1.Controls.Add(this.nextbtn);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.gobtn);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.posterimg);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(180)))));
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            // 
            // savebtn
            // 
            this.savebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.savebtn.ButtonImage = null;
            this.savebtn.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.savebtn.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.savebtn.ButtonText = "Save";
            this.savebtn.CornerRadius = 5;
            this.savebtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.savebtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.savebtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.savebtn.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            resources.ApplyResources(this.savebtn, "savebtn");
            this.savebtn.Name = "savebtn";
            this.savebtn.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.savebtn.SelectedTextColor = System.Drawing.Color.White;
            this.savebtn.SuperSelected = false;
            this.savebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.savebtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.loadbtn.ButtonImage = null;
            this.loadbtn.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.loadbtn.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.loadbtn.ButtonText = "Load";
            this.loadbtn.CornerRadius = 5;
            this.loadbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.loadbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.loadbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.loadbtn.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            resources.ApplyResources(this.loadbtn, "loadbtn");
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.loadbtn.SelectedTextColor = System.Drawing.Color.White;
            this.loadbtn.SuperSelected = false;
            this.loadbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.loadbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.loadbtn.Click += new System.EventHandler(this.load_Click);
            // 
            // runtime
            // 
            resources.ApplyResources(this.runtime, "runtime");
            this.runtime.BackColor = System.Drawing.Color.Transparent;
            this.runtime.ForeColor = System.Drawing.Color.White;
            this.runtime.Name = "runtime";
            // 
            // year
            // 
            resources.ApplyResources(this.year, "year");
            this.year.BackColor = System.Drawing.Color.Transparent;
            this.year.ForeColor = System.Drawing.Color.White;
            this.year.Name = "year";
            // 
            // genretext
            // 
            resources.ApplyResources(this.genretext, "genretext");
            this.genretext.BackColor = System.Drawing.Color.Transparent;
            this.genretext.ForeColor = System.Drawing.Color.White;
            this.genretext.Name = "genretext";
            // 
            // titletext
            // 
            resources.ApplyResources(this.titletext, "titletext");
            this.titletext.BackColor = System.Drawing.Color.Transparent;
            this.titletext.ForeColor = System.Drawing.Color.White;
            this.titletext.Name = "titletext";
            // 
            // searchbox
            // 
            this.searchbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.searchbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.searchbox.BorderThickness = 3;
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.searchbox, "searchbox");
            this.searchbox.ForeColor = System.Drawing.Color.LightGray;
            this.searchbox.isPassword = false;
            this.searchbox.Name = "searchbox";
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchbox.OnValueChanged += new System.EventHandler(this.SearchBox_OnValueChanged);
            // 
            // prevbtn
            // 
            this.prevbtn.BackColor = System.Drawing.Color.Transparent;
            this.prevbtn.Image = global::Movie_Search.Properties.Resources.l;
            this.prevbtn.ImageActive = null;
            resources.ApplyResources(this.prevbtn, "prevbtn");
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.TabStop = false;
            this.prevbtn.Zoom = 10;
            this.prevbtn.Click += new System.EventHandler(this.prev_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.Color.Transparent;
            this.nextbtn.Image = global::Movie_Search.Properties.Resources.r;
            this.nextbtn.ImageActive = null;
            resources.ApplyResources(this.nextbtn, "nextbtn");
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.TabStop = false;
            this.nextbtn.Zoom = 10;
            this.nextbtn.Click += new System.EventHandler(this.next_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // gobtn
            // 
            this.gobtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gobtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("gobtn.ButtonImage")));
            this.gobtn.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.gobtn.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.gobtn.ButtonText = "Go";
            this.gobtn.CornerRadius = 5;
            this.gobtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.gobtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.gobtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.gobtn.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            resources.ApplyResources(this.gobtn, "gobtn");
            this.gobtn.Name = "gobtn";
            this.gobtn.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.gobtn.SelectedTextColor = System.Drawing.Color.White;
            this.gobtn.SuperSelected = false;
            this.gobtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.gobtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.gobtn.Click += new System.EventHandler(this.Go_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // posterimg
            // 
            this.posterimg.Image = global::Movie_Search.Properties.Resources.Halation_movies_film_art_background_vector_01;
            resources.ApplyResources(this.posterimg, "posterimg");
            this.posterimg.Name = "posterimg";
            this.posterimg.TabStop = false;
            // 
            // MovieSearch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(77)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.header);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MovieSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton exitbtn;
        private XanderUI.XUISuperButton gobtn;
        private System.Windows.Forms.PictureBox posterimg;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton prevbtn;
        private Bunifu.Framework.UI.BunifuImageButton nextbtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchbox;
        private System.Windows.Forms.Label runtime;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label genretext;
        private System.Windows.Forms.Label titletext;
        private System.Windows.Forms.Label label6;
        private XanderUI.XUISuperButton savebtn;
        private XanderUI.XUISuperButton loadbtn;
    }
}

