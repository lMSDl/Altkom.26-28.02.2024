﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Client
    {
        public static void Execute()
        {
            var textBox = new TextBox { Name = "textBox" };
            var textBoxFrame = new Frame() { Name = "textBoxFrame" };
            textBoxFrame.Add(textBox);
            var button = new Button() { Name = "buttonClear" };
            button.OnClick = () =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return false;
                textBox.Text = string.Empty;
                return true;
            };

            var buttonFrame = new Frame() { Name = "buttonClearFrame" };
            buttonFrame.Add(button);

            textBox.Add(buttonFrame);


            var buttonAccept = new Button() { Name = "buttonAccept" };
            buttonAccept.OnClick = () =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return false;
                Console.WriteLine($"Wprowadziłeś tekst: {textBox.Text}");
                return true;
            };
            textBoxFrame.Add(buttonAccept);


            Console.WriteLine("--");
            textBoxFrame.Click();
            Console.WriteLine("--");
            button.Click();
            Console.WriteLine("--");
            textBox.Click();
            Console.WriteLine("--");
            textBox.Text = "ala ma kota";
            Console.WriteLine("--");
            button.Click();
            Console.WriteLine("--");
            button.Click();

        }
    }
}
