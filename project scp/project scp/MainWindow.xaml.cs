
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace project_scp
{

    public partial class MainWindow : Window
    {
        private enum Alakzatok
        {
            Vonal, Kor, Negyszog, Szabadkezi
        }
        private Alakzatok jelenlegiAlakzat = Alakzatok.Vonal;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Gomb_Vonal_Click(object sender, RoutedEventArgs e)
        {
            jelenlegiAlakzat = Alakzatok.Vonal;
        }

        private void Gomb_Kor_Click(object sender, RoutedEventArgs e)
        {
            jelenlegiAlakzat = Alakzatok.Kor;
        }

        private void Gomb_Negyszög_Click(object sender, RoutedEventArgs e)
        {
            jelenlegiAlakzat = Alakzatok.Negyszog;
        }
        Point start;
        Point veg;

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                veg = e.GetPosition(this);
            }
            start = e.GetPosition(this);
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Szabadkezi.IsChecked == false)
            {
                switch (jelenlegiAlakzat)
                {
                    case Alakzatok.Vonal:
                        VonalRajz();
                        break;
                    case Alakzatok.Kor:
                        KorRajz();
                        break;
                    case Alakzatok.Negyszog:
                        NegyszogRajz();
                        break;
                    default:
                        return;
                }
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed && Szabadkezi.IsChecked == true)
            {
                Line vonal = new Line();
                vonal.X1 = start.X;
                vonal.Y1 = start.Y;
                vonal.X2 = e.GetPosition(this).X;
                vonal.Y2 = e.GetPosition(this).Y;
                start = e.GetPosition(this);
                Vaszon.Children.Add(vonal);
                vonal.StrokeThickness = vastagsag.Value;
                if (V1 == 1)
                {
                    vonal.Stroke = Brushes.Black;
                }
                else if (V2 == 1)
                {
                    vonal.Stroke = Brushes.White;

                }
                else if (V3 == 1)
                {
                    vonal.Stroke = Brushes.Red;
                }
                else if (V4 == 1)
                {
                    vonal.Stroke = Brushes.Lime;
                }
                else if (V5 == 1)
                {
                    vonal.Stroke = Brushes.Blue;
                }
                else if (V6 == 1)
                {
                    vonal.Stroke = Brushes.Yellow;
                }
                else if (V7 == 1)
                {
                    vonal.Stroke = Brushes.Cyan;
                }
                else if (V8 == 1)
                {
                    vonal.Stroke = Brushes.Fuchsia;
                }
                else if (V9 == 1)
                {
                    vonal.Stroke = Brushes.Silver;
                }
                else if (V10 == 1)
                {
                    vonal.Stroke = Brushes.Gray;
                }
                else if (V11 == 1)
                {
                    vonal.Stroke = Brushes.Maroon;
                }
                else if (V12 == 1)
                {
                    vonal.Stroke = Brushes.Olive;
                }
                else if (V13 == 1)
                {
                    vonal.Stroke = Brushes.Green;
                }
                else if (V14 == 1)
                {
                    vonal.Stroke = Brushes.Purple;
                }
                else if (V15 == 1)
                {
                    vonal.Stroke = Brushes.Navy;
                }
            }
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                veg = e.GetPosition(this);

            }

        }   
        private void VonalRajz()
        {
            Line ujVonal = new Line()
            {
                X1 = start.X,
                Y1 = start.Y - 50,
                X2 = veg.X,
                Y2 = veg.Y - 50
            };
            ujVonal.StrokeThickness = vastagsag.Value;
            if (V1 == 1)
            {
                ujVonal.Stroke = Brushes.Black;
            }
            else if (V2 == 1)
            {
                ujVonal.Stroke = Brushes.White;

            }
            else if (V3 == 1)
            {
                ujVonal.Stroke = Brushes.Red;
            }
            else if (V4 == 1)
            {
                ujVonal.Stroke = Brushes.Lime;
            }
            else if (V5 == 1)
            {
                ujVonal.Stroke = Brushes.Blue;
            }
            else if (V6 == 1)
            {
                ujVonal.Stroke = Brushes.Yellow;
            }
            else if (V7 == 1)
            {
                ujVonal.Stroke = Brushes.Cyan;
            }
            else if (V8 == 1)
            {
                ujVonal.Stroke = Brushes.Fuchsia;
            }
            else if (V9 == 1)
            {
                ujVonal.Stroke = Brushes.Silver;
            }
            else if (V10 == 1)
            {
                ujVonal.Stroke = Brushes.Gray;
            }
            else if (V11 == 1)
            {
                ujVonal.Stroke = Brushes.Maroon;
            }
            else if (V12 == 1)
            {
                ujVonal.Stroke = Brushes.Olive;
            }
            else if (V13 == 1)
            {
                ujVonal.Stroke = Brushes.Green;
            }
            else if (V14 == 1)
            {
                ujVonal.Stroke = Brushes.Purple;
            }
            else if (V15 == 1)
            {
                ujVonal.Stroke = Brushes.Navy;
            }
            Vaszon.Children.Add(ujVonal);
        }
        public int K1, K2, K3, K4, K5, K6, K7, K8, K9, K10, K11, K12, K13, K14, K15;
        public int  V2, V3, V4, V5, V6, V7, V8, V9, V10, V11, V12, V13, V14, V15;
        public int V1=1;



        private void KorRajz()
        {
            Ellipse ujKor = new Ellipse()
            {
                StrokeThickness = 4,
                Height = 10,
                Width = 10
            };
            if (V1 == 1)
            {
                ujKor.Stroke = Brushes.Black;
            }
            else if (V2 == 1)
            {
                ujKor.Stroke = Brushes.White;

            }
            else if (V3 == 1)
            {
                ujKor.Stroke = Brushes.Red;
            }
            else if (V4 == 1)
            {
                ujKor.Stroke = Brushes.Lime;
            }
            else if (V5 == 1)
            {
                ujKor.Stroke = Brushes.Blue;
            }
            else if (V6 == 1)
            {
                ujKor.Stroke = Brushes.Yellow;
            }
            else if (V7 == 1)
            {
                ujKor.Stroke = Brushes.Cyan;
            }
            else if (V8 == 1)
            {
                ujKor.Stroke = Brushes.Fuchsia;
            }
            else if (V9 == 1)
            {
                ujKor.Stroke = Brushes.Silver;
            }
            else if (V10 == 1)
            {
                ujKor.Stroke = Brushes.Gray;
            }
            else if (V11 == 1)
            {
                ujKor.Stroke = Brushes.Maroon;
            }
            else if (V12 == 1)
            {
                ujKor.Stroke = Brushes.Olive;
            }
            else if (V13 == 1)
            {
                ujKor.Stroke = Brushes.Green;
            }
            else if (V14 == 1)
            {
                ujKor.Stroke = Brushes.Purple;
            }
            else if (V15 == 1)
            {
                ujKor.Stroke = Brushes.Navy;
            }

            if (veg.X >= start.X)
            {
                ujKor.SetValue(Canvas.LeftProperty, start.X);
                ujKor.Width = veg.X - start.X;
            }
            else
            {
                ujKor.SetValue(Canvas.LeftProperty, veg.X);
                ujKor.Width = start.X - veg.X;
            }

            if (K1 == 1)
            {
                ujKor.Fill = Brushes.Black;
            }
            else if (K2 == 1)
            {
                ujKor.Fill = Brushes.White;

            }
            else if (K3 == 1)
            {
                ujKor.Fill = Brushes.Red;
            }
            else if (K4 == 1)
            {
                ujKor.Fill = Brushes.Lime;
            }
            else if (K5 == 1)
            {
                ujKor.Fill = Brushes.Blue;
            }
            else if (K6 == 1)
            {
                ujKor.Fill = Brushes.Yellow;
            }
            else if (K7 == 1)
            {
                ujKor.Fill = Brushes.Cyan;
            }
            else if (K8 == 1)
            {
                ujKor.Fill = Brushes.Fuchsia;
            }
            else if (K9 == 1)
            {
                ujKor.Fill = Brushes.Silver;
            }
            else if (K10 == 1)
            {
                ujKor.Fill = Brushes.Gray;
            }
            else if (K11 == 1)
            {
                ujKor.Fill = Brushes.Maroon;
            }
            else if (K12 == 1)
            {
                ujKor.Fill = Brushes.Olive;
            }
            else if (K13 == 1)
            {
                ujKor.Fill = Brushes.Green;
            }
            else if (K14 == 1)
            {
                ujKor.Fill = Brushes.Purple;
            }
            else if (K15 == 1)
            {
                ujKor.Fill = Brushes.Navy;
            }
            if (veg.X >= start.X)
            {
                ujKor.SetValue(Canvas.LeftProperty, start.X);
                ujKor.Width = veg.X - start.X;
            }
            else
            {
                ujKor.SetValue(Canvas.LeftProperty, veg.X);
                ujKor.Width = start.X - veg.X;
            }
            //y koordunáta
            if (veg.Y >= start.Y)
            {
                ujKor.SetValue(Canvas.TopProperty, start.Y - 50);
                ujKor.Height = veg.Y - start.Y;
            }
            else
            {
                ujKor.SetValue(Canvas.TopProperty, veg.Y - 50);
                ujKor.Height = start.Y - veg.Y;
            }
            Vaszon.Children.Add(ujKor);

        }
        private void NegyszogRajz()
        {
            Rectangle ujNegyszog = new Rectangle()
            {
                Stroke = Brushes.Black,
                StrokeThickness = 4,
            };
            if (V1 == 1)
            {
                ujNegyszog.Stroke = Brushes.Black;
            }
            else if (V2 == 1)
            {
                ujNegyszog.Stroke = Brushes.White;

            }
            else if (V3 == 1)
            {
                ujNegyszog.Stroke = Brushes.Red;
            }
            else if (V4 == 1)
            {
                ujNegyszog.Stroke = Brushes.Lime;
            }
            else if (V5 == 1)
            {
                ujNegyszog.Stroke = Brushes.Blue;
            }
            else if (V6 == 1)
            {
                ujNegyszog.Stroke = Brushes.Yellow;
            }
            else if (V7 == 1)
            {
                ujNegyszog.Stroke = Brushes.Cyan;
            }
            else if (V8 == 1)
            {
                ujNegyszog.Stroke = Brushes.Fuchsia;
            }
            else if (V9 == 1)
            {
                ujNegyszog.Stroke = Brushes.Silver;
            }
            else if (V10 == 1)
            {
                ujNegyszog.Stroke = Brushes.Gray;
            }
            else if (V11 == 1)
            {
                ujNegyszog.Stroke = Brushes.Maroon;
            }
            else if (V12 == 1)
            {
                ujNegyszog.Stroke = Brushes.Olive;
            }
            else if (V13 == 1)
            {
                ujNegyszog.Stroke = Brushes.Green;
            }
            else if (V14 == 1)
            {
                ujNegyszog.Stroke = Brushes.Purple;
            }
            else if (V15 == 1)
            {
                ujNegyszog.Stroke = Brushes.Navy;
            }

            if (K1 == 1)
            {
                ujNegyszog.Fill = Brushes.Black;
            }
            else if (K2 == 1)
            {
                ujNegyszog.Fill = Brushes.White;

            }
            else if (K3 == 1)
            {
                ujNegyszog.Fill = Brushes.Red;
            }
            else if (K4 == 1)
            {
                ujNegyszog.Fill = Brushes.Lime;
            }
            else if (K5 == 1)
            {
                ujNegyszog.Fill = Brushes.Blue;
            }
            else if (K6 == 1)
            {
                ujNegyszog.Fill = Brushes.Yellow;
            }
            else if (K7 == 1)
            {
                ujNegyszog.Fill = Brushes.Cyan;
            }
            else if (K8 == 1)
            {
                ujNegyszog.Fill = Brushes.Fuchsia;
            }
            else if (K9 == 1)
            {
                ujNegyszog.Fill = Brushes.Silver;
            }
            else if (K10 == 1)
            {
                ujNegyszog.Fill = Brushes.Gray;
            }
            else if (K11 == 1)
            {
                ujNegyszog.Fill = Brushes.Maroon;
            }
            else if (K12 == 1)
            {
                ujNegyszog.Fill = Brushes.Olive;
            }
            else if (K13 == 1)
            {
                ujNegyszog.Fill = Brushes.Green;
            }
            else if (K14 == 1)
            {
                ujNegyszog.Fill = Brushes.Purple;
            }
            else if (K15 == 1)
            {
                ujNegyszog.Fill = Brushes.Navy;
            }
            if (veg.X >= start.X)
            {
                ujNegyszog.SetValue(Canvas.LeftProperty, start.X);
                ujNegyszog.Width = veg.X - start.X;
            }
            else
            {
                ujNegyszog.SetValue(Canvas.LeftProperty, veg.X);
                ujNegyszog.Width = start.X - veg.X;
            }
            //y koordunáta
            if (veg.Y >= start.Y)
            {
                ujNegyszog.SetValue(Canvas.TopProperty, start.Y - 50);
                ujNegyszog.Height = veg.Y - start.Y;
            }
            else
            {
                ujNegyszog.SetValue(Canvas.TopProperty, veg.Y - 50);
                ujNegyszog.Height = start.Y - veg.Y;
            }
            Vaszon.Children.Add(ujNegyszog);

        }

        private void Szabadkezi_Checked(object sender, MouseEventArgs e)
        { }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            K1 = 1;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }
        private void k2_Click(object sender, RoutedEventArgs e)
        {
            
                K1 = 0;
                K2 = 1;
                K3 = 0;
                K4 = 0;
                K5 = 0;
                K6 = 0;
                K7 = 0;
                K8 = 0;
                K9 = 0;
                K10 = 0;
                K11 = 0;
                K12 = 0;
                K13 = 0;
                K14 = 0;
                K15 = 0;

            
        }
        private void k3_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 1;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k4_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 1;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Vaszon.Children.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            save.ShowDialog();
        }

        private void k5_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 1;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k6_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 1;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k7_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 1;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k8_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 1;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k9_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 1;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k10_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 1;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k11_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 1;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k12_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 1;
            K13 = 0;
            K14 = 0;
            K15 = 0;
        }

        private void k13_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 1;
            K14 = 0;
            K15 = 0;
        }

        private void k14_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 1;
            K15 = 0;
        }

        private void k15_Click(object sender, RoutedEventArgs e)
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            K5 = 0;
            K6 = 0;
            K7 = 0;
            K8 = 0;
            K9 = 0;
            K10 = 0;
            K11 = 0;
            K12 = 0;
            K13 = 0;
            K14 = 0;
            K15 = 1;
        }
        private void v1_Click(object sender, RoutedEventArgs e)
        {
            V1 = 1;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v2_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 1;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v3_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 1;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v4_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 1;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v5_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 1;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v6_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 1;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v7_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 1;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v8_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 1;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v9_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 1;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v10_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 =1;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v11_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 1;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v12_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 1;
            V13 = 0;
            V14 = 0;
            V15 = 0;
        }

        private void v13_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 1;
            V14 = 0;
            V15 = 0;
        }

        private void v14_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 1;
            V15 = 0;
        }

        private void v15_Click(object sender, RoutedEventArgs e)
        {
            V1 = 0;
            V2 = 0;
            V3 = 0;
            V4 = 0;
            V5 = 0;
            V6 = 0;
            V7 = 0;
            V8 = 0;
            V9 = 0;
            V10 = 0;
            V11 = 0;
            V12 = 0;
            V13 = 0;
            V14 = 0;
            V15 = 1;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

    }
}



