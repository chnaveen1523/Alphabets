using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Pattern objPattern = new Pattern();
        //objPattern.APattern();
        //objPattern.BPattern();
        //objPattern.CPattern();
        //objPattern.DPattern();
        //objPattern.EPattern();
        //objPattern.FPattern();
        //objPattern.GPattern();
        //objPattern.HPattern();
        //objPattern.IPattern();
        //objPattern.JPattern();
        //objPattern.KPattern();
        //objPattern.LPattern();
        //objPattern.MPattern();
        //objPattern.NPattern();
        //objPattern.OPattern();
        //objPattern.PPattern();
        //objPattern.QPattern();
        //objPattern.RPattern();
        //objPattern.SPattern();
        //objPattern.TPattern();
        //objPattern.UPattern();
        //objPattern.VPattern();
        //objPattern.VPattern();
        //objPattern.WPattern();
        //objPattern.XPattern();
        //objPattern.YPattern();
        objPattern.ZPattern();
    }
}

public class Pattern
{
    int i, j;

    public void APattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || i == 3 || j == 1 || j == 5)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    public void BPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || i == 3 || i == 5 || j == 1 || j == 5)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }


    public void CPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || i == 5 || j == 1)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void DPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || i == 5 || j == 1 || j == 5)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void EPattern()
    {
        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || i == 4 && j <= 4 || i == 7 || j == 1)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void FPattern()
    {
        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || i == 4 && j <= 4 || j == 1)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void GPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || i == 5 || j == 1 || i == 3 && j >= 3 || j == 5 && i >= 3)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void HPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || j == 5 || i == 3)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void IPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || i == 5 || j == 3)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void JPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || j == 3 || i == 5 && j <= 3 || j == 1 && i >= 3)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void KPattern()
    {
        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || j + i == 6 || i - j == 2)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void LPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || i == 5)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void MPattern()
    {
        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || j == 5 || i == 2 && j >= 2 && j <= 2 || i == 3 && j == 3 || i == 2 && j == 4)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void NPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || j == 5 || i - j == 0)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void OPattern()
    {
        for (i = 1; i <= 6; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 && j >= 2 && j <= 4 || i == 6 && j >= 2 && j <= 4 || j == 1 && i <= 5 && i >= 2 || j == 5 && i <= 5 && i >= 2)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void PPattern()
    {
        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 && j <= 4 || i == 4 && j <= 4 || j == 1 || j == 5 && i <= 3 && i >= 2)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void QPattern()
    {
        for (i = 1; i <= 8; i++)
        {
            for (j = 1; j <= 7; j++)
            {
                if (j == 1 && i <= 5 || j == 5 && i <= 5 || i == 1 && j <= 5 || i == 5 && j <= 5 || i == 3 && j >= 3 && j <= 3 || i == 4 && j >= 4 && j <= 4 ||
                i == 5 && j >= 5 && j <= 5 || i == 6 && j >= 6 && j <= 6 || i == 7 && j >= 7 && j <= 7)
                {
                    Console.Write("*");

                }

                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void RPattern()
    {
        for (i = 1; i <= 6; i++)
        {
            for (j = 1; j <= 6; j++)
            {
                if (j == 1 || i == 1 && j <= 4 || i == 3 && j <= 4 || j == 5 && i == 2 || i == 4 && j == 3 || i == 5 && j == 4 || i == 6 && j == 5)
                {
                    Console.Write("*");

                }

                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void SPattern()
    {
        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 && j >= 2 || i == 4 && j >= 2 && j <= 4 || i == 7 && j <= 4 || j == 1 && i <= 3 && i >= 2 || j == 5 && i >= 5 && i <= 6)

                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void TPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 || j == 3)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void UPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 5 || j == 1 || j == 5)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void VPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 && i <= 4 || j == 5 && i <= 4 || j == 3 && i >= 5)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void WPattern()
    {
        for (i = 1; i <= 6; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 && i <= 5 || j == 2 && i == 6 || j == 3 && i >= 4 && i <= 5 || j == 4 && i == 6 || j == 5 && i <= 5)

                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void XPattern()
    {
        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 && i <= 2 || j == 1 && i == 6 || j == 1 && i == 7 ||
                   j == 2 && i == 3 || j == 2 && i == 5 ||
                   j == 3 && i == 4 ||
                   j == 4 && i == 3 || j == 4 && i == 5 ||
                   j == 5 && i <= 2 || j == 5 && i == 6 || j == 5 && i == 7)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void YPattern()
    {
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 && i <= 2 || j == 2 && i == 3 || j == 3 && i >= 4 || j == 4 && i == 3 || j == 5 && i <= 2)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public void ZPattern()
    {
        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 7; j++)
            {
                if (i == 1 || i == 7 || j == 6 && i == 2 || j == 5 && i == 3 || j == 4 && i == 4 || j == 3 && i == 5 ||
                   j == 2 && i == 6)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

}}