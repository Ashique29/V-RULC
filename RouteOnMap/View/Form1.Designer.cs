namespace RouteOnMap
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
            this.txt_userinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_map = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.RouteMap = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // txt_userinput
            // 
            this.txt_userinput.Location = new System.Drawing.Point(192, 74);
            this.txt_userinput.Name = "txt_userinput";
            this.txt_userinput.Size = new System.Drawing.Size(168, 22);
            this.txt_userinput.TabIndex = 2;
            this.txt_userinput.TextChanged += new System.EventHandler(this.txt_userinput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location Address";
            // 
            // btn_map
            // 
            this.btn_map.Location = new System.Drawing.Point(253, 119);
            this.btn_map.Name = "btn_map";
            this.btn_map.Size = new System.Drawing.Size(106, 23);
            this.btn_map.TabIndex = 4;
            this.btn_map.Text = "Show map";
            this.btn_map.UseVisualStyleBackColor = true;
            this.btn_map.Click += new System.EventHandler(this.btn_map_Click);
            // 
            // RouteMap
            // 
            this.RouteMap.Bearing = 0F;
            this.RouteMap.CanDragMap = true;
            this.RouteMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.RouteMap.GrayScaleMode = false;
            this.RouteMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.RouteMap.LevelsKeepInMemmory = 5;
            this.RouteMap.Location = new System.Drawing.Point(421, 74);
            this.RouteMap.MarkersEnabled = true;
            this.RouteMap.MaxZoom = 2;
            this.RouteMap.MinZoom = 2;
            this.RouteMap.MouseWheelZoomEnabled = true;
            this.RouteMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.RouteMap.Name = "RouteMap";
            this.RouteMap.NegativeMode = false;
            this.RouteMap.PolygonsEnabled = true;
            this.RouteMap.RetryLoadTile = 0;
            this.RouteMap.RoutesEnabled = true;
            this.RouteMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.RouteMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.RouteMap.ShowTileGridLines = false;
            this.RouteMap.Size = new System.Drawing.Size(348, 317);
            this.RouteMap.TabIndex = 1;
            this.RouteMap.Zoom = 0D;
            this.RouteMap.Load += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_map);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userinput);
            this.Controls.Add(this.RouteMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_userinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_map;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private GMap.NET.WindowsForms.GMapControl RouteMap;
    }
}

