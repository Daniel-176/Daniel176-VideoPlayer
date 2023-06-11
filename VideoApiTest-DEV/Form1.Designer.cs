namespace VideoApiTest_DEV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listITEMS = new System.Windows.Forms.ListBox();
            this.textofrandomthingy = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.videotitle = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // listITEMS
            // 
            this.listITEMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listITEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listITEMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listITEMS.ForeColor = System.Drawing.Color.White;
            this.listITEMS.FormattingEnabled = true;
            this.listITEMS.Items.AddRange(new object[] {
            "LOADING..."});
            this.listITEMS.Location = new System.Drawing.Point(485, 12);
            this.listITEMS.Name = "listITEMS";
            this.listITEMS.Size = new System.Drawing.Size(282, 442);
            this.listITEMS.TabIndex = 0;
            this.listITEMS.SelectedIndexChanged += new System.EventHandler(this.listITEMS_SelectedIndexChanged);
            // 
            // textofrandomthingy
            // 
            this.textofrandomthingy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textofrandomthingy.AutoSize = true;
            this.textofrandomthingy.ForeColor = System.Drawing.Color.White;
            this.textofrandomthingy.Location = new System.Drawing.Point(13, 441);
            this.textofrandomthingy.Name = "textofrandomthingy";
            this.textofrandomthingy.Size = new System.Drawing.Size(99, 13);
            this.textofrandomthingy.TabIndex = 2;
            this.textofrandomthingy.Text = "Made by Daniel176";
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(13, 13);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(466, 293);
            this.player.TabIndex = 3;
            // 
            // videotitle
            // 
            this.videotitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.videotitle.AutoSize = true;
            this.videotitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videotitle.Location = new System.Drawing.Point(13, 313);
            this.videotitle.Name = "videotitle";
            this.videotitle.Size = new System.Drawing.Size(14, 20);
            this.videotitle.TabIndex = 4;
            this.videotitle.Text = " ";
            // 
            // type
            // 
            this.type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.type.ForeColor = System.Drawing.Color.White;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Buscando o Herobrine - 1° Temporada",
            "Buscando o Herobrine - 2° Temporada",
            "Videos do Vicente",
            "Videos Aleatorios"});
            this.type.Location = new System.Drawing.Point(291, 313);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(188, 52);
            this.type.TabIndex = 6;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(779, 466);
            this.Controls.Add(this.type);
            this.Controls.Add(this.videotitle);
            this.Controls.Add(this.player);
            this.Controls.Add(this.textofrandomthingy);
            this.Controls.Add(this.listITEMS);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Daniel176.ml Video Player Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listITEMS;
        private System.Windows.Forms.Label textofrandomthingy;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label videotitle;
        private System.Windows.Forms.ListBox type;
    }
}

