namespace GraphAssign2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            label1 = new Label();
            btnDrawChart = new Button();
            pieChartPanel = new Panel();
            legendListView = new ListView();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(157, 39);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 46);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Number:";
            // 
            // btnDrawChart
            // 
            btnDrawChart.Location = new Point(317, 39);
            btnDrawChart.Name = "btnDrawChart";
            btnDrawChart.Size = new Size(94, 29);
            btnDrawChart.TabIndex = 2;
            btnDrawChart.Text = "Draw Chart";
            btnDrawChart.UseVisualStyleBackColor = true;
            btnDrawChart.Click += btnDrawChart_Click;
            // 
            // pieChartPanel
            // 
            pieChartPanel.Location = new Point(85, 114);
            pieChartPanel.Name = "pieChartPanel";
            pieChartPanel.Size = new Size(326, 301);
            pieChartPanel.TabIndex = 3;
            // 
            // legendListView
            // 
            legendListView.Location = new Point(456, 114);
            legendListView.Name = "legendListView";
            legendListView.Size = new Size(105, 191);
            legendListView.TabIndex = 4;
            legendListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(609, 453);
            Controls.Add(legendListView);
            Controls.Add(pieChartPanel);
            Controls.Add(btnDrawChart);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Pie Graph";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label label1;
        private Button btnDrawChart;
        private Panel pieChartPanel;
        private ListView legendListView;
    }
}
