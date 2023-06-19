using System.Drawing;
using System.Windows.Forms;

public class TransparentBackgroundTextBox : TextBox
{
    public TransparentBackgroundTextBox()
    {

        SetStyle(ControlStyles.SupportsTransparentBackColor |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.UserPaint, true);
        BackColor = Color.Transparent;
    }

    public sealed override Color BackColor
    {
        get => base.BackColor;
        set => base.BackColor = value;
    }
}