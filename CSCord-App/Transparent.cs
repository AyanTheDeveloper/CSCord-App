﻿using System;
using System.Windows.Forms;

public class TransparentRichTextBox : RichTextBox
{
    public TransparentRichTextBox()
    {
        this.SetStyle(ControlStyles.Opaque, true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
    }
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams parms = base.CreateParams;
            parms.ExStyle |= 0x20;  // Turn on WS_EX_TRANSPARENT
            return parms;
        }
    }
}