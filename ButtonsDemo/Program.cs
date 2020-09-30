using System;

namespace ButtonsDemo
{
    class Program
    {
        class Button
        {
            public event EventHandler Click;
            public void OnClick()
            {
                Click?.Invoke(null, null);
            }
        }
        static void Main(string[] args)
        {
            Button btn = new Button();
            btn.Click += Btn_Click;
            btn.OnClick();

        }
        private static void Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button was clicked");
        }
    }
}