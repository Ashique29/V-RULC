namespace RouteOnMap
{
    partial class Form2
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
            this.RouteMap2 = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // RouteMap2
            // 
            this.RouteMap2.Bearing = 0F;
            this.RouteMap2.CanDragMap = true;
            this.RouteMap2.EmptyTileColor = System.Drawing.Color.Navy;
            this.RouteMap2.GrayScaleMode = false;
            this.RouteMap2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.RouteMap2.LevelsKeepInMemmory = 5;
            this.RouteMap2.Location = new System.Drawing.Point(399, 72);
            this.RouteMap2.MarkersEnabled = true;
            this.RouteMap2.MaxZoom = 2;
            this.RouteMap2.MinZoom = 2;
            this.RouteMap2.MouseWheelZoomEnabled = true;
            this.RouteMap2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.RouteMap2.Name = "RouteMap2";
            this.RouteMap2.NegativeMode = false;
            this.RouteMap2.PolygonsEnabled = true;
            this.RouteMap2.RetryLoadTile = 0;
            this.RouteMap2.RoutesEnabled = true;
            this.RouteMap2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.RouteMap2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.RouteMap2.ShowTileGridLines = false;
            this.RouteMap2.Size = new System.Drawing.Size(348, 317);
            this.RouteMap2.TabIndex = 1;
            this.RouteMap2.Zoom = 0D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RouteMap2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl RouteMap2;
    }
}