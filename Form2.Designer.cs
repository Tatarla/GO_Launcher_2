namespace GOR_Launcher
{
    partial class AddFilesForm
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
            this.addDx11Label = new MaterialSkin.Controls.MaterialLabel();
            this.addDx11Switch = new MaterialSkin.Controls.MaterialSwitch();
            this.addFontsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.addFontsSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.addNoGrassSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.addNoGrassLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // addDx11Label
            // 
            this.addDx11Label.AutoSize = true;
            this.addDx11Label.BackColor = System.Drawing.Color.Transparent;
            this.addDx11Label.Depth = 0;
            this.addDx11Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addDx11Label.Location = new System.Drawing.Point(12, 84);
            this.addDx11Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.addDx11Label.Name = "addDx11Label";
            this.addDx11Label.Size = new System.Drawing.Size(40, 19);
            this.addDx11Label.TabIndex = 1;
            this.addDx11Label.Text = "DX11";
            // 
            // addDx11Switch
            // 
            this.addDx11Switch.AutoSize = true;
            this.addDx11Switch.BackColor = System.Drawing.Color.Transparent;
            this.addDx11Switch.Depth = 0;
            this.addDx11Switch.Location = new System.Drawing.Point(253, 75);
            this.addDx11Switch.Margin = new System.Windows.Forms.Padding(0);
            this.addDx11Switch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.addDx11Switch.MouseState = MaterialSkin.MouseState.HOVER;
            this.addDx11Switch.Name = "addDx11Switch";
            this.addDx11Switch.Ripple = true;
            this.addDx11Switch.Size = new System.Drawing.Size(58, 37);
            this.addDx11Switch.TabIndex = 2;
            this.addDx11Switch.UseVisualStyleBackColor = false;
            this.addDx11Switch.CheckedChanged += new System.EventHandler(this.addDx11Switch_CheckedChanged);
            // 
            // addFontsLabel
            // 
            this.addFontsLabel.AutoSize = true;
            this.addFontsLabel.BackColor = System.Drawing.Color.Transparent;
            this.addFontsLabel.Depth = 0;
            this.addFontsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addFontsLabel.Location = new System.Drawing.Point(12, 121);
            this.addFontsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addFontsLabel.Name = "addFontsLabel";
            this.addFontsLabel.Size = new System.Drawing.Size(157, 19);
            this.addFontsLabel.TabIndex = 3;
            this.addFontsLabel.Text = "High Resolution Fonts";
            // 
            // addFontsSwitch
            // 
            this.addFontsSwitch.AutoSize = true;
            this.addFontsSwitch.BackColor = System.Drawing.Color.Transparent;
            this.addFontsSwitch.Depth = 0;
            this.addFontsSwitch.Location = new System.Drawing.Point(253, 112);
            this.addFontsSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.addFontsSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.addFontsSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.addFontsSwitch.Name = "addFontsSwitch";
            this.addFontsSwitch.Ripple = true;
            this.addFontsSwitch.Size = new System.Drawing.Size(58, 37);
            this.addFontsSwitch.TabIndex = 4;
            this.addFontsSwitch.UseVisualStyleBackColor = false;
            this.addFontsSwitch.CheckedChanged += new System.EventHandler(this.addFontsSwitch_CheckedChanged);
            // 
            // addNoGrassSwitch
            // 
            this.addNoGrassSwitch.AutoSize = true;
            this.addNoGrassSwitch.BackColor = System.Drawing.Color.Transparent;
            this.addNoGrassSwitch.Depth = 0;
            this.addNoGrassSwitch.Location = new System.Drawing.Point(252, 149);
            this.addNoGrassSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.addNoGrassSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.addNoGrassSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNoGrassSwitch.Name = "addNoGrassSwitch";
            this.addNoGrassSwitch.Ripple = true;
            this.addNoGrassSwitch.Size = new System.Drawing.Size(58, 37);
            this.addNoGrassSwitch.TabIndex = 6;
            this.addNoGrassSwitch.UseVisualStyleBackColor = false;
            this.addNoGrassSwitch.CheckedChanged += new System.EventHandler(this.noGrassSwitch_CheckedChanged);
            // 
            // addNoGrassLabel
            // 
            this.addNoGrassLabel.AutoSize = true;
            this.addNoGrassLabel.BackColor = System.Drawing.Color.Transparent;
            this.addNoGrassLabel.Depth = 0;
            this.addNoGrassLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addNoGrassLabel.Location = new System.Drawing.Point(11, 158);
            this.addNoGrassLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNoGrassLabel.Name = "addNoGrassLabel";
            this.addNoGrassLabel.Size = new System.Drawing.Size(66, 19);
            this.addNoGrassLabel.TabIndex = 5;
            this.addNoGrassLabel.Text = "No Grass";
            // 
            // AddFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 197);
            this.Controls.Add(this.addNoGrassSwitch);
            this.Controls.Add(this.addNoGrassLabel);
            this.Controls.Add(this.addFontsSwitch);
            this.Controls.Add(this.addFontsLabel);
            this.Controls.Add(this.addDx11Switch);
            this.Controls.Add(this.addDx11Label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFilesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Additional Content";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel addDx11Label;
        private MaterialSkin.Controls.MaterialSwitch addDx11Switch;
        private MaterialSkin.Controls.MaterialLabel addFontsLabel;
        private MaterialSkin.Controls.MaterialSwitch addFontsSwitch;
        private MaterialSkin.Controls.MaterialSwitch addNoGrassSwitch;
        private MaterialSkin.Controls.MaterialLabel addNoGrassLabel;
    }
}