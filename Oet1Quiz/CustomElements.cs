using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System;
using System.Threading.Tasks;
using Oet1Quiz;

namespace ZsoltCustomElements
{
    public class ResizeableRadioButton : RadioButton
    {
        public Color _backgroundOfPanel = MainWindow.MainWindowBackgroundColor;

        public Color BackgroundOfPanel
        {
            get => _backgroundOfPanel;
            set
            {
                _backgroundOfPanel = value;
                Invalidate();
            }
        }

        public ResizeableRadioButton()
        {
            AutoSize = false;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            Width = TextRenderer.MeasureText(Text, Font).Width + Height + 50;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(_backgroundOfPanel), 0, 0, Width, Height);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(new SolidBrush(Color.White), 0, 0, Height, Height);

            if(Checked) e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 60, 201)), 5, 5, Height - 10, Height - 10);

            e.Graphics.DrawString(Text, Font, new SolidBrush(Color.White), Height + 5, Height / 4);
        }
    }

    class ResizeableCheckbox : CheckBox
    {
        public Color _backgroundOfPanel = MainWindow.MainWindowBackgroundColor;

        public Color BackgroundOfPanel
        {
            get => _backgroundOfPanel;
            set
            {
                _backgroundOfPanel = value;
                Invalidate();
            }
        }

        public ResizeableCheckbox()
        {
            TextAlign = ContentAlignment.MiddleLeft;
            /*this.TextAlign = ContentAlignment.Midd;*/
            Padding = new Padding((Height / 2) + 10, 10, 0, 0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int h = this.ClientSize.Height - 2;
            e.Graphics.FillRectangle(new SolidBrush(_backgroundOfPanel), 0, 0, Width, Height);
            var rc = new Rectangle(new Point(-1, this.Height / 2 - h / 2), new Size(h, h));
            if (this.FlatStyle == FlatStyle.Flat)
            {
                ControlPaint.DrawCheckBox(e.Graphics, rc, this.Checked ? ButtonState.Flat | ButtonState.Checked : ButtonState.Flat | ButtonState.Normal);
            }
            else
            {
                ControlPaint.DrawCheckBox(e.Graphics, rc, this.Checked ? ButtonState.Checked : ButtonState.Normal);
            }

            e.Graphics.DrawString(Text, Font, new SolidBrush(Color.White), (Height / 2 - h / 2) + 50, Height / 4);
        }
    }

    class RoundedButton : Button
    {
        #region Propeties

        #region Private backing fields
        private Color _backgroundColor = Color.White;
        private Color _textColor = Color.Black;
        private Color _onHoverColor = Color.Gray;
        private Color _disabledColor = Color.Gray;
        private float _animationDuration = 1000f;
        private float _buttonRadius = 5f;

        #endregion

        #region Getters / Setters

        [Category("Custom Propeties")]
        [Description("Background color of button")]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                Invalidate();
            }
        }

        [Category("Custom Propeties")]
        [Description("Text color of button")]
        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        [Category("Custom Propeties")]
        [Description("Background color of button on hover")]
        public Color OnHoverBackgroundColor
        {
            get => _onHoverColor;
            set
            {
                _onHoverColor = value;
                Invalidate();
            }
        }

        [Category("Custom Propeties")]
        [Description("Background color of button on hover")]
        public Color DisabledColor
        {
            get => _disabledColor;
            set
            {
                _disabledColor = value;
                Invalidate();
            }
        }

        [Category("Custom Propeties")]
        [Description("Duration of animation")]
        public float AnimationDuration
        {
            get => _animationDuration / 1000;
            set
            {
                _animationDuration = value * 1000;
                Invalidate();
            }
        }

        [Category("Custom Propeties")]
        [Description("Radius of the button")]
        public float Radius
        {
            get => _buttonRadius;
            set
            {
                _buttonRadius = value;
                Invalidate();
            }
        }

        #endregion

        #endregion

        private bool isHovering = false;

        private int currentBackgroundR;
        private int currentBackgroundG;
        private int currentBackgroundB;

        public RoundedButton()
        {
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Transparent;
            currentBackgroundR = _backgroundColor.R;
            currentBackgroundG = _backgroundColor.G;
            currentBackgroundB = _backgroundColor.B;


            MouseEnter += (sender, e) =>
            {
                isHovering = true;
                ToHoverColor();
            };

            MouseLeave += (sender, e) =>
            {
                isHovering = false;
                ToUnhoverColor();
            };
        }

        void MoveToColor(int stepR, int stepG, int stepB, Color newTarget)
        {
            int newR = currentBackgroundR + stepR;
            if (stepR > 0 ? newR < newTarget.R : newR >= newTarget.R && newR >= 0 && newR < 256) currentBackgroundR = newR;

            int newG = currentBackgroundG + stepG;
            if (stepG > 0 ? newG < newTarget.G : newG >= newTarget.G && newG >= 0 && newG < 256) currentBackgroundG = newG;

            int newB = currentBackgroundB + stepB;
            if (stepB > 0 ? newB < newTarget.B : newB >= newTarget.B && newB >= 0 && newB < 256) currentBackgroundB = newB;
        }

        async void ToHoverColor ()
        {
            float stepR = (_onHoverColor.R - currentBackgroundR) / (_animationDuration / 50f);
            float stepG = (_onHoverColor.G - currentBackgroundG) / (_animationDuration / 50f);
            float stepB = (_onHoverColor.B - currentBackgroundB) / (_animationDuration / 50f);

            for (float i = 0; i < _animationDuration / 1.5; i+=20)
            {
                if (!isHovering) break;

                MoveToColor((int)stepR, (int)stepG, (int)stepB, _onHoverColor);
                Invalidate();
                await Task.Delay(20);
            }
        }

        async void ToUnhoverColor()
        {
            float stepR = (_backgroundColor.R - currentBackgroundR) / (_animationDuration / 50f);
            float stepG = (_backgroundColor.G - currentBackgroundG) / (_animationDuration / 50f);
            float stepB = (_backgroundColor.B - currentBackgroundB) / (_animationDuration / 50f);

            for (float i = 0; i < _animationDuration / 1.5; i += 20)
            {
                if (isHovering) break;

                MoveToColor((int)stepR, (int)stepG, (int)stepB, _backgroundColor);
                Invalidate();
                await Task.Delay(20);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(Enabled ? Color.FromArgb(currentBackgroundR, currentBackgroundG, currentBackgroundB) : _disabledColor);


            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, (Width - Height), 0, Height, Height);

            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);


            brush.Dispose();
            brush = new SolidBrush(_textColor);

            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }
    }
}
