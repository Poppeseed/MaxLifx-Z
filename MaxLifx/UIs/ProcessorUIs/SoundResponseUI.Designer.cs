﻿using System;

namespace MaxLifx.UIs
{
    partial class SoundResponseUI
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
            MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy analogousColourStrategy1 = new MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy();
            MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy analogousColourStrategy2 = new MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy();
            MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy analogousColourStrategy3 = new MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy();
            MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy analogousColourStrategy4 = new MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy();
            MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy analogousColourStrategy5 = new MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy();
            MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy analogousColourStrategy6 = new MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy();
            MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy analogousColourStrategy7 = new MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy();
            MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy analogousColourStrategy8 = new MaxLifx.Controls.ColourStrategy.AnalogousColourStrategy();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHues = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbLockBrightness = new System.Windows.Forms.CheckBox();
            this.cbPastelThemes = new System.Windows.Forms.CheckBox();
            this.pThemes = new System.Windows.Forms.Panel();
            this.brightnessSelector1 = new MaxLifx.Controls.BrightnessSelector.BrightnessSelector();
            this.cbBrightnessInvert = new System.Windows.Forms.CheckBox();
            this.cbFree = new System.Windows.Forms.CheckBox();
            this.cbPerBulb = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbHueInvert = new System.Windows.Forms.CheckBox();
            this.cbLinkRanges = new System.Windows.Forms.CheckBox();
            this.cbSaturationInvert = new System.Windows.Forms.CheckBox();
            this.hueSelector1 = new MaxLifx.Controls.HueSelector.HueSelector();
            this.btnCentreRanges = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.cbUpdateAudioResponse = new System.Windows.Forms.CheckBox();
            this.spectrumAnalyser1 = new MaxLifx.Controls.SpectrumAnalyser();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOnTimes = new System.Windows.Forms.TextBox();
            this.tbOffTimes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nDelay = new System.Windows.Forms.NumericUpDown();
            this.cbWaveType = new System.Windows.Forms.ComboBox();
            this.nTransition = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nWaveDuration = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbReorder = new System.Windows.Forms.CheckBox();
            this.bDown = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.lbLabels = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabHues.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTransition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWaveDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabHues);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(266, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 539);
            this.tabControl1.TabIndex = 114;
            // 
            // tabHues
            // 
            this.tabHues.BackColor = System.Drawing.SystemColors.Control;
            this.tabHues.Controls.Add(this.button4);
            this.tabHues.Controls.Add(this.groupBox3);
            this.tabHues.Controls.Add(this.brightnessSelector1);
            this.tabHues.Controls.Add(this.cbBrightnessInvert);
            this.tabHues.Controls.Add(this.cbFree);
            this.tabHues.Controls.Add(this.cbPerBulb);
            this.tabHues.Controls.Add(this.button2);
            this.tabHues.Controls.Add(this.cbHueInvert);
            this.tabHues.Controls.Add(this.cbLinkRanges);
            this.tabHues.Controls.Add(this.cbSaturationInvert);
            this.tabHues.Controls.Add(this.hueSelector1);
            this.tabHues.Controls.Add(this.btnCentreRanges);
            this.tabHues.Location = new System.Drawing.Point(4, 22);
            this.tabHues.Name = "tabHues";
            this.tabHues.Padding = new System.Windows.Forms.Padding(3);
            this.tabHues.Size = new System.Drawing.Size(855, 513);
            this.tabHues.TabIndex = 0;
            this.tabHues.Text = "Hues";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(708, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 117;
            this.button4.Text = "Zero Ranges";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbLockBrightness);
            this.groupBox3.Controls.Add(this.cbPastelThemes);
            this.groupBox3.Controls.Add(this.pThemes);
            this.groupBox3.Location = new System.Drawing.Point(712, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 324);
            this.groupBox3.TabIndex = 113;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Themes";
            // 
            // cbLockBrightness
            // 
            this.cbLockBrightness.AutoSize = true;
            this.cbLockBrightness.Location = new System.Drawing.Point(11, 37);
            this.cbLockBrightness.Name = "cbLockBrightness";
            this.cbLockBrightness.Size = new System.Drawing.Size(102, 17);
            this.cbLockBrightness.TabIndex = 2;
            this.cbLockBrightness.Text = "Lock Brightness";
            this.cbLockBrightness.UseVisualStyleBackColor = true;
            // 
            // cbPastelThemes
            // 
            this.cbPastelThemes.AutoSize = true;
            this.cbPastelThemes.Location = new System.Drawing.Point(11, 19);
            this.cbPastelThemes.Name = "cbPastelThemes";
            this.cbPastelThemes.Size = new System.Drawing.Size(55, 17);
            this.cbPastelThemes.TabIndex = 1;
            this.cbPastelThemes.Text = "Pastel";
            this.cbPastelThemes.UseVisualStyleBackColor = true;
            // 
            // pThemes
            // 
            this.pThemes.AutoScroll = true;
            this.pThemes.Location = new System.Drawing.Point(9, 68);
            this.pThemes.Name = "pThemes";
            this.pThemes.Size = new System.Drawing.Size(119, 240);
            this.pThemes.TabIndex = 0;
            // 
            // brightnessSelector1
            // 
            this.brightnessSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brightnessSelector1.Brightness = 0D;
            this.brightnessSelector1.Free = false;
            this.brightnessSelector1.GenericColourStrategy = analogousColourStrategy1;
            this.brightnessSelector1.HandleCount = 1;
            this.brightnessSelector1.Invert = false;
            this.brightnessSelector1.LinkRanges = false;
            this.brightnessSelector1.Location = new System.Drawing.Point(530, 10);
            this.brightnessSelector1.Name = "brightnessSelector1";
            this.brightnessSelector1.PerBulb = false;
            this.brightnessSelector1.SelectedOneColourStrategy = analogousColourStrategy2;
            this.brightnessSelector1.SelectedThreeColourStrategy = analogousColourStrategy3;
            this.brightnessSelector1.SelectedTwoColourStrategy = analogousColourStrategy4;
            this.brightnessSelector1.Size = new System.Drawing.Size(162, 492);
            this.brightnessSelector1.TabIndex = 116;
            this.brightnessSelector1.Text = "brightnessSelector1";
            this.brightnessSelector1.BrightnessesChanged += new System.EventHandler(this.BrightnessesChanged);
            // 
            // cbBrightnessInvert
            // 
            this.cbBrightnessInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBrightnessInvert.AutoSize = true;
            this.cbBrightnessInvert.Location = new System.Drawing.Point(705, 61);
            this.cbBrightnessInvert.Name = "cbBrightnessInvert";
            this.cbBrightnessInvert.Size = new System.Drawing.Size(105, 17);
            this.cbBrightnessInvert.TabIndex = 101;
            this.cbBrightnessInvert.Text = "Invert Hue Order";
            this.cbBrightnessInvert.UseVisualStyleBackColor = true;
            this.cbBrightnessInvert.CheckedChanged += new System.EventHandler(this.cbBrightnessInvert_CheckedChanged);
            // 
            // cbFree
            // 
            this.cbFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFree.AutoSize = true;
            this.cbFree.Location = new System.Drawing.Point(705, 27);
            this.cbFree.Name = "cbFree";
            this.cbFree.Size = new System.Drawing.Size(75, 17);
            this.cbFree.TabIndex = 111;
            this.cbFree.Text = "Link Bulbs";
            this.cbFree.UseVisualStyleBackColor = true;
            this.cbFree.CheckedChanged += new System.EventHandler(this.cbFree_CheckedChanged);
            // 
            // cbPerBulb
            // 
            this.cbPerBulb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPerBulb.AutoSize = true;
            this.cbPerBulb.Checked = true;
            this.cbPerBulb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPerBulb.Location = new System.Drawing.Point(705, 10);
            this.cbPerBulb.Name = "cbPerBulb";
            this.cbPerBulb.Size = new System.Drawing.Size(99, 17);
            this.cbPerBulb.TabIndex = 108;
            this.cbPerBulb.Text = "Colour Per Bulb";
            this.cbPerBulb.UseVisualStyleBackColor = true;
            this.cbPerBulb.CheckedChanged += new System.EventHandler(this.cbPerBulb_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(708, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 109;
            this.button2.Text = "Reset Ranges";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbHueInvert
            // 
            this.cbHueInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHueInvert.AutoSize = true;
            this.cbHueInvert.Location = new System.Drawing.Point(705, 95);
            this.cbHueInvert.Margin = new System.Windows.Forms.Padding(460, 460, 3, 3);
            this.cbHueInvert.Name = "cbHueInvert";
            this.cbHueInvert.Size = new System.Drawing.Size(140, 17);
            this.cbHueInvert.TabIndex = 103;
            this.cbHueInvert.Text = "Invert Brightness Range";
            this.cbHueInvert.UseVisualStyleBackColor = true;
            this.cbHueInvert.CheckedChanged += new System.EventHandler(this.cbHueInvert_CheckedChanged);
            // 
            // cbLinkRanges
            // 
            this.cbLinkRanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLinkRanges.AutoSize = true;
            this.cbLinkRanges.Location = new System.Drawing.Point(705, 44);
            this.cbLinkRanges.Name = "cbLinkRanges";
            this.cbLinkRanges.Size = new System.Drawing.Size(86, 17);
            this.cbLinkRanges.TabIndex = 110;
            this.cbLinkRanges.Text = "Link Ranges";
            this.cbLinkRanges.UseVisualStyleBackColor = true;
            this.cbLinkRanges.CheckedChanged += new System.EventHandler(this.cbLinkRanges_CheckedChanged);
            // 
            // cbSaturationInvert
            // 
            this.cbSaturationInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSaturationInvert.AutoSize = true;
            this.cbSaturationInvert.Location = new System.Drawing.Point(705, 78);
            this.cbSaturationInvert.Name = "cbSaturationInvert";
            this.cbSaturationInvert.Size = new System.Drawing.Size(133, 17);
            this.cbSaturationInvert.TabIndex = 102;
            this.cbSaturationInvert.Text = "Invert Saturation Order";
            this.cbSaturationInvert.UseVisualStyleBackColor = true;
            this.cbSaturationInvert.CheckedChanged += new System.EventHandler(this.cbSaturationInvert_CheckedChanged);
            // 
            // hueSelector1
            // 
            this.hueSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hueSelector1.BackColor = System.Drawing.SystemColors.Control;
            this.hueSelector1.Free = false;
            this.hueSelector1.GenericColourStrategy = analogousColourStrategy5;
            this.hueSelector1.HandleCount = 1;
            this.hueSelector1.Invert = false;
            this.hueSelector1.LinkRanges = false;
            this.hueSelector1.Location = new System.Drawing.Point(0, 0);
            this.hueSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.hueSelector1.Name = "hueSelector1";
            this.hueSelector1.PerBulb = false;
            this.hueSelector1.SelectedOneColourStrategy = analogousColourStrategy6;
            this.hueSelector1.SelectedThreeColourStrategy = analogousColourStrategy7;
            this.hueSelector1.SelectedTwoColourStrategy = analogousColourStrategy8;
            this.hueSelector1.Size = new System.Drawing.Size(517, 514);
            this.hueSelector1.TabIndex = 107;
            this.hueSelector1.Text = "z";
            this.hueSelector1.HuesChanged += new System.EventHandler(this.colourControl1_HuesChanged);
            // 
            // btnCentreRanges
            // 
            this.btnCentreRanges.Location = new System.Drawing.Point(690, 245);
            this.btnCentreRanges.Name = "btnCentreRanges";
            this.btnCentreRanges.Size = new System.Drawing.Size(18, 20);
            this.btnCentreRanges.TabIndex = 117;
            this.btnCentreRanges.Text = "<";
            this.btnCentreRanges.UseVisualStyleBackColor = true;
            this.btnCentreRanges.Click += new System.EventHandler(this.btnCentreRanges_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.cbUpdateAudioResponse);
            this.tabPage2.Controls.Add(this.spectrumAnalyser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Audio Frequency Response";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(644, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 108;
            this.button3.Text = "Reset Ranges";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbUpdateAudioResponse
            // 
            this.cbUpdateAudioResponse.AutoSize = true;
            this.cbUpdateAudioResponse.BackColor = System.Drawing.Color.Transparent;
            this.cbUpdateAudioResponse.Checked = true;
            this.cbUpdateAudioResponse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpdateAudioResponse.Location = new System.Drawing.Point(629, 6);
            this.cbUpdateAudioResponse.Name = "cbUpdateAudioResponse";
            this.cbUpdateAudioResponse.Size = new System.Drawing.Size(121, 30);
            this.cbUpdateAudioResponse.TabIndex = 114;
            this.cbUpdateAudioResponse.Text = "update in real \r\ntime (CPU intensive)";
            this.cbUpdateAudioResponse.UseVisualStyleBackColor = false;
            this.cbUpdateAudioResponse.CheckedChanged += new System.EventHandler(this.cbUpdateAudioResponse_CheckedChanged);
            // 
            // spectrumAnalyser1
            // 
            this.spectrumAnalyser1.Location = new System.Drawing.Point(0, 0);
            this.spectrumAnalyser1.Name = "spectrumAnalyser1";
            this.spectrumAnalyser1.Size = new System.Drawing.Size(512, 512);
            this.spectrumAnalyser1.TabIndex = 107;
            this.spectrumAnalyser1.Text = "spectrumAnalyser1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbOnTimes);
            this.groupBox4.Controls.Add(this.tbOffTimes);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.nDelay);
            this.groupBox4.Controls.Add(this.cbWaveType);
            this.groupBox4.Controls.Add(this.nTransition);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.nWaveDuration);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(5, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 222);
            this.groupBox4.TabIndex = 106;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Turn Off at:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Turn On at:";
            // 
            // tbOnTimes
            // 
            this.tbOnTimes.Location = new System.Drawing.Point(95, 166);
            this.tbOnTimes.Name = "tbOnTimes";
            this.tbOnTimes.Size = new System.Drawing.Size(99, 20);
            this.tbOnTimes.TabIndex = 100;
            this.tbOnTimes.TextChanged += new System.EventHandler(this.tbOnTimes_TextChanged);
            // 
            // tbOffTimes
            // 
            this.tbOffTimes.Location = new System.Drawing.Point(94, 192);
            this.tbOffTimes.Name = "tbOffTimes";
            this.tbOffTimes.Size = new System.Drawing.Size(100, 20);
            this.tbOffTimes.TabIndex = 99;
            this.tbOffTimes.TextChanged += new System.EventHandler(this.tbOffTimes_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 23);
            this.button1.TabIndex = 95;
            this.button1.Text = "Reset Wave Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nDelay
            // 
            this.nDelay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nDelay.Location = new System.Drawing.Point(94, 19);
            this.nDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nDelay.Name = "nDelay";
            this.nDelay.Size = new System.Drawing.Size(100, 20);
            this.nDelay.TabIndex = 88;
            this.nDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nDelay.ValueChanged += new System.EventHandler(this.nDelay_ValueChanged);
            // 
            // cbWaveType
            // 
            this.cbWaveType.FormattingEnabled = true;
            this.cbWaveType.Location = new System.Drawing.Point(95, 84);
            this.cbWaveType.Name = "cbWaveType";
            this.cbWaveType.Size = new System.Drawing.Size(101, 21);
            this.cbWaveType.TabIndex = 87;
            this.cbWaveType.SelectedIndexChanged += new System.EventHandler(this.cbWaveType_SelectedIndexChanged);
            // 
            // nTransition
            // 
            this.nTransition.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nTransition.Location = new System.Drawing.Point(95, 45);
            this.nTransition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nTransition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTransition.Name = "nTransition";
            this.nTransition.Size = new System.Drawing.Size(100, 20);
            this.nTransition.TabIndex = 89;
            this.nTransition.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nTransition.ValueChanged += new System.EventHandler(this.nTransition_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Delay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Transition";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "ms";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "Wave Duration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "ms";
            // 
            // nWaveDuration
            // 
            this.nWaveDuration.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nWaveDuration.Location = new System.Drawing.Point(95, 111);
            this.nWaveDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nWaveDuration.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nWaveDuration.Name = "nWaveDuration";
            this.nWaveDuration.Size = new System.Drawing.Size(100, 20);
            this.nWaveDuration.TabIndex = 96;
            this.nWaveDuration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nWaveDuration.ValueChanged += new System.EventHandler(this.nWaveDuration_Changed);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Wave Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbReorder);
            this.groupBox1.Controls.Add(this.bDown);
            this.groupBox1.Controls.Add(this.bUp);
            this.groupBox1.Controls.Add(this.lbLabels);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 304);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Bulbs to Use:";
            // 
            // cbReorder
            // 
            this.cbReorder.AutoSize = true;
            this.cbReorder.Location = new System.Drawing.Point(74, 274);
            this.cbReorder.Name = "cbReorder";
            this.cbReorder.Size = new System.Drawing.Size(64, 17);
            this.cbReorder.TabIndex = 113;
            this.cbReorder.Text = "Reorder";
            this.cbReorder.UseVisualStyleBackColor = true;
            this.cbReorder.CheckedChanged += new System.EventHandler(this.cbReorder_CheckedChanged);
            // 
            // bDown
            // 
            this.bDown.Enabled = false;
            this.bDown.Location = new System.Drawing.Point(194, 270);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(44, 23);
            this.bDown.TabIndex = 112;
            this.bDown.Text = "Down";
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.bDown_Click);
            // 
            // bUp
            // 
            this.bUp.Enabled = false;
            this.bUp.Location = new System.Drawing.Point(144, 270);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(44, 23);
            this.bUp.TabIndex = 111;
            this.bUp.Text = "Up";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // lbLabels
            // 
            this.lbLabels.FormattingEnabled = true;
            this.lbLabels.Location = new System.Drawing.Point(4, 16);
            this.lbLabels.Name = "lbLabels";
            this.lbLabels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbLabels.Size = new System.Drawing.Size(234, 251);
            this.lbLabels.TabIndex = 86;
            this.lbLabels.SelectedIndexChanged += new System.EventHandler(this.lbLabels_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 537);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 538);
            this.panel1.TabIndex = 116;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // SoundResponseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "SoundResponseUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SoundResponseUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoundResponseUI_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.SoundResponseUI_ResizeEnd);
            this.tabControl1.ResumeLayout(false);
            this.tabHues.ResumeLayout(false);
            this.tabHues.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTransition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWaveDuration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.CheckBox cbBrightnessInvert;
        private System.Windows.Forms.CheckBox cbSaturationInvert;
        private System.Windows.Forms.CheckBox cbHueInvert;
        private MaxLifx.Controls.HueSelector.HueSelector hueSelector1;
        private System.Windows.Forms.CheckBox cbPerBulb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbLinkRanges;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox cbFree;
        private Controls.SpectrumAnalyser spectrumAnalyser1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbUpdateAudioResponse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHues;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pThemes;
        private Controls.BrightnessSelector.BrightnessSelector brightnessSelector1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cbPastelThemes;
        private System.Windows.Forms.CheckBox cbLockBrightness;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbReorder;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.ListBox lbLabels;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOnTimes;
        private System.Windows.Forms.TextBox tbOffTimes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nDelay;
        private System.Windows.Forms.ComboBox cbWaveType;
        private System.Windows.Forms.NumericUpDown nTransition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nWaveDuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCentreRanges;
    }
}