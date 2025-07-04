﻿namespace Rubiks_Cube_Solver.Solver.Forms
{
    partial class OutputSolution
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
            this.lblCubeOrientation = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblStageName = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblSequenceHeader = new System.Windows.Forms.Label();
            this.lblExplanationHeader = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCubeOrientation
            // 
            this.lblCubeOrientation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCubeOrientation.BackColor = System.Drawing.Color.Thistle;
            this.lblCubeOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCubeOrientation.Location = new System.Drawing.Point(116, 34);
            this.lblCubeOrientation.MinimumSize = new System.Drawing.Size(598, 164);
            this.lblCubeOrientation.Name = "lblCubeOrientation";
            this.lblCubeOrientation.Size = new System.Drawing.Size(598, 205);
            this.lblCubeOrientation.TabIndex = 0;
            this.lblCubeOrientation.Text = "Hold your cube with the white face on top and the green face facing you.";
            this.lblCubeOrientation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSequence
            // 
            this.lblSequence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblSequence.Location = new System.Drawing.Point(116, 407);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(598, 419);
            this.lblSequence.TabIndex = 1;
            this.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnFinish.Location = new System.Drawing.Point(1213, 745);
            this.btnFinish.MinimumSize = new System.Drawing.Size(114, 45);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(176, 81);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.TabStop = false;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblStageName
            // 
            this.lblStageName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblStageName.Location = new System.Drawing.Point(847, 34);
            this.lblStageName.MaximumSize = new System.Drawing.Size(589, 164);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(542, 164);
            this.lblStageName.TabIndex = 3;
            this.lblStageName.Text = "Stage:";
            this.lblStageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExplanation
            // 
            this.lblExplanation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(847, 351);
            this.lblExplanation.MaximumSize = new System.Drawing.Size(589, 559);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(542, 374);
            this.lblExplanation.TabIndex = 4;
            this.lblExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSequenceHeader
            // 
            this.lblSequenceHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSequenceHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSequenceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblSequenceHeader.Location = new System.Drawing.Point(116, 310);
            this.lblSequenceHeader.MaximumSize = new System.Drawing.Size(598, 97);
            this.lblSequenceHeader.MinimumSize = new System.Drawing.Size(598, 97);
            this.lblSequenceHeader.Name = "lblSequenceHeader";
            this.lblSequenceHeader.Size = new System.Drawing.Size(598, 97);
            this.lblSequenceHeader.TabIndex = 5;
            this.lblSequenceHeader.Text = "Sequence Of Moves:";
            this.lblSequenceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExplanationHeader
            // 
            this.lblExplanationHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExplanationHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExplanationHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanationHeader.Location = new System.Drawing.Point(847, 308);
            this.lblExplanationHeader.MaximumSize = new System.Drawing.Size(227, 43);
            this.lblExplanationHeader.MinimumSize = new System.Drawing.Size(227, 43);
            this.lblExplanationHeader.Name = "lblExplanationHeader";
            this.lblExplanationHeader.Size = new System.Drawing.Size(227, 43);
            this.lblExplanationHeader.TabIndex = 6;
            this.lblExplanationHeader.Text = "Explanation:";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.LightCyan;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(1509, 36);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(226, 86);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // OutputSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 900);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblExplanationHeader);
            this.Controls.Add(this.lblSequenceHeader);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.lblStageName);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblSequence);
            this.Controls.Add(this.lblCubeOrientation);
            this.MinimumSize = new System.Drawing.Size(1468, 869);
            this.Name = "OutputSolution";
            this.Text = "Output_Solution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OutputSolution_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCubeOrientation;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblStageName;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblSequenceHeader;
        private System.Windows.Forms.Label lblExplanationHeader;
        private System.Windows.Forms.Button btnMenu;
    }
}