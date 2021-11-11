using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tictactoe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int hero_turn=0;
        static bool win = false;
        static int [,] massiv= {{-1,-1,-1}, {-1,-1,-1},{-1,-1,-1}};
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool winlose(int [,] massiv_temp) {
            if (((massiv_temp[0,0]==1)& (massiv_temp[1, 0] == 1) & (massiv_temp[2, 0] == 1)) 
                | ((massiv_temp[0, 0] == 1) & (massiv_temp[1, 1] == 1) & (massiv_temp[2, 2] == 1))
                | ((massiv_temp[0, 0] == 1) & (massiv_temp[0, 1] == 1) & (massiv_temp[0, 2] == 1))
                | ((massiv_temp[1, 0] == 1) & (massiv_temp[1, 1] == 1) & (massiv_temp[1, 2] == 1))
                | ((massiv_temp[2, 0] == 1) & (massiv_temp[2, 1] == 1) & (massiv_temp[2, 2] == 1))
                | ((massiv_temp[0, 2] == 1) & (massiv_temp[1, 2] == 1) & (massiv_temp[2, 2] == 1))
                | ((massiv_temp[2, 0] == 1) & (massiv_temp[1, 1] == 1) & (massiv_temp[0, 2] == 1))
                | ((massiv_temp[0, 1] == 1) & (massiv_temp[1, 1] == 1) & (massiv_temp[2, 1] == 1))
                )
            {
                win = true;
            }
            if (((massiv_temp[0, 0] == 0) & (massiv_temp[1, 0] == 0) & (massiv_temp[2, 0] == 0))
                | ((massiv_temp[0, 0] == 0) & (massiv_temp[1, 1] == 0) & (massiv_temp[2, 2] == 0))
                | ((massiv_temp[0, 0] == 0) & (massiv_temp[0, 1] == 0) & (massiv_temp[0, 2] == 0))
                | ((massiv_temp[1, 0] == 0) & (massiv_temp[1, 1] == 0) & (massiv_temp[1, 2] == 0))
                | ((massiv_temp[2, 0] == 0) & (massiv_temp[2, 1] == 0) & (massiv_temp[2, 2] == 0))
                | ((massiv_temp[0, 2] == 0) & (massiv_temp[1, 2] == 0) & (massiv_temp[2, 2] == 0))
                | ((massiv_temp[2, 0] == 0) & (massiv_temp[1, 1] == 0) & (massiv_temp[0, 2] == 0))
                | ((massiv_temp[0, 1] == 0) & (massiv_temp[1, 1] == 0) & (massiv_temp[2, 1] == 0))
                )
            {
                win = true;
            }
                return win;
        }

        private void endis() {

            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
        }
        private void round_draw() {
            if (btn1.IsEnabled == false & btn2.IsEnabled == false & btn3.IsEnabled == false & btn4.IsEnabled == false & btn5.IsEnabled == false & btn6.IsEnabled == false
                & btn7.IsEnabled == false & btn8.IsEnabled == false & btn9.IsEnabled == false & winlose(massiv) == false) {
                player_turn.Content = "Ничья";
            }
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            
            switch ((sender as Button).Name)
            {
                case "btn1":
                    if (hero_turn == 0)
                    {
                        btn1.Content = "X";
                        massiv[0, 0] = 1;
                        
                        if (winlose(massiv)) {
                            player_turn.Content ="Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn1.IsEnabled = false;
                        round_draw();
                    }
                    else {
                        btn1.Content = "O";
                        massiv[0, 0] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn1.IsEnabled = false;
                        round_draw();
                    }
                    break;
                case "btn2":
                    if (hero_turn == 0)
                    {
                        btn2.Content = "X";
                        massiv[0, 1] = 1;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn2.IsEnabled = false;
                        round_draw();
                    }
                    else
                    {
                        btn2.Content = "O";
                        massiv[0, 1] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn2.IsEnabled = false;
                        round_draw();
                    }
                    break;

                case "btn3":
                    if (hero_turn == 0)
                    {
                        btn3.Content = "X";
                        massiv[0, 2] = 1;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn3.IsEnabled = false;
                        round_draw();
                    }
                    else
                    {
                        btn3.Content = "O";
                        massiv[0, 2] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn3.IsEnabled = false;
                        round_draw();
                    }
                    break;

                case "btn4":
                    if (hero_turn == 0)
                    {
                        btn4.Content = "X";
                        massiv[1, 0] = 1;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn4.IsEnabled = false;
                        round_draw();
                    }
                    else
                    {
                        btn4.Content = "O";
                        massiv[1, 0] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn4.IsEnabled = false;
                        round_draw();
                    }
                    break;

                case "btn5":
                    if (hero_turn == 0)
                    {
                        btn5.Content = "X";
                        massiv[1, 1] = 1;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn5.IsEnabled = false;
                        round_draw();
                    }
                    else
                    {
                        btn5.Content = "O";
                        massiv[1, 1] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn5.IsEnabled = false;
                        round_draw();
                    }
                    break;

                case "btn6":
                    if (hero_turn == 0)
                    {
                        btn6.Content = "X";
                        massiv[1, 2] = 1;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn6.IsEnabled = false;
                        round_draw();
                    }
                    else
                    {
                        btn6.Content = "O";
                        massiv[1, 2] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn6.IsEnabled = false;
                        round_draw();
                    }
                    break;

                case "btn7":
                    if (hero_turn == 0)
                    {
                        btn7.Content = "X";
                        massiv[2, 0] = 1;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn7.IsEnabled = false;
                        round_draw();
                    }
                    else
                    {
                        btn7.Content = "O";
                        massiv[2, 0] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn7.IsEnabled = false;
                        round_draw();
                    }
                    break;

                case "btn8":
                    if (hero_turn == 0)
                    {
                        btn8.Content = "X";
                        massiv[2, 1] = 1;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn8.IsEnabled = false;
                        round_draw();
                    }
                    else
                    {
                        btn8.Content = "O";
                        massiv[2, 1] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn8.IsEnabled = false;
                        round_draw();
                    }
                    break;

                case "btn9":
                    if (hero_turn == 0)
                    {
                        btn9.Content = "X";
                        massiv[2, 2] = 1;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли крестики";
                            endis();
                        }
                        hero_turn = 1;
                        btn9.IsEnabled = false;
                        round_draw();
                    }
                    else
                    {
                        btn9.Content = "O";
                        massiv[2, 2] = 0;
                        if (winlose(massiv))
                        {
                            player_turn.Content = "Выиграли нолики";
                            endis();
                        }
                        hero_turn = 0;
                        btn9.IsEnabled = false;
                        round_draw();
                    }
                    break;
            }
        }

        private void new_game_Click(object sender, RoutedEventArgs e)
        {
            hero_turn = 0;
           
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    massiv[i, j] = -1;
                }
            }
            win = false;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
            player_turn.Content = "";
        }
    }
}
