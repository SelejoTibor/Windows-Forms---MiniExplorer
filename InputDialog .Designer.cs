namespace WinFormsApp
{
    partial class InputDialog
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
            tPath = new TextBox();
            labelPath = new Label();
            bCancel = new Button();
            bOk = new Button();
            SuspendLayout();
            // 
            // tPath
            // 
            tPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tPath.Location = new Point(55, 7);
            tPath.Name = "tPath";
            tPath.Size = new Size(224, 27);
            tPath.TabIndex = 0;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(12, 10);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(37, 20);
            labelPath.TabIndex = 1;
            labelPath.Text = "Path";
            // 
            // bCancel
            // 
            bCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bCancel.DialogResult = DialogResult.Cancel;
            bCancel.Location = new Point(185, 76);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(94, 29);
            bCancel.TabIndex = 2;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // bOk
            // 
            bOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bOk.DialogResult = DialogResult.OK;
            bOk.Location = new Point(12, 76);
            bOk.Name = "bOk";
            bOk.Size = new Size(94, 29);
            bOk.TabIndex = 3;
            bOk.Text = "Ok";
            bOk.UseVisualStyleBackColor = true;
            // 
            // InputDialog
            // 
            AcceptButton = bOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bCancel;
            ClientSize = new Size(291, 117);
            Controls.Add(bOk);
            Controls.Add(bCancel);
            Controls.Add(labelPath);
            Controls.Add(tPath);
            Name = "InputDialog";
            Text = "InputDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tPath;
        private Label labelPath;
        private Button bCancel;
        private Button bOk;
    }
}