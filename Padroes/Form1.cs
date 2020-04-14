using Padroes.Patterns.Behavioral.ChainOfResponsability;
using Padroes.Patterns.Behavioral.Command;
using Padroes.Patterns.Behavioral.Command.TestThread;
using Padroes.Patterns.Behavioral.Interpreter;
using Padroes.Patterns.Behavioral.Iterator;
using Padroes.Patterns.Behavioral.Mediator;
using Padroes.Patterns.Behavioral.Memento;
using Padroes.Patterns.Behavioral.Observer;
using Padroes.Patterns.Behavioral.State;
using Padroes.Patterns.Behavioral.Strategy;
using Padroes.Patterns.Behavioral.TemplateMethod;
using Padroes.Patterns.Behavioral.Visitor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padroes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestChainOfResponsability.Testar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestCommand.Testar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestCommandThread.Testar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TestInterpreter.Testar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TestePilha.Testar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TestIterator.Testar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TestMediator.Testar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Memento memento = new Memento();
            memento.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TestObserver.Testar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TestState.Testar();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TestStrategy.Testar();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TestTemplateMethod.Testar();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TestVisitor.Testar();
        }
    }
}
