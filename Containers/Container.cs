using System;
using System.Collections.Generic;
using System.Text;

namespace Containers
{
    class Container
    {
        Stack<string> Local1 = new Stack<string>();
        Stack<string> Local2 = new Stack<string>();
        Stack<string> Local3 = new Stack<string>();
        Stack<string> Local4 = new Stack<string>();
        public int x;
        public string Cod;
        int[] cont;
        public void menu()
        {
            int i = 0;
            
            while (i != 3)
            {
                cont = new int[4] { Local1.Count, Local2.Count, Local3.Count, Local4.Count };
                Console.Clear();
                Console.WriteLine("1 - Empilhar\n2 - Desempilhar\n3 - Sair ");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Informe o codigo");
                        Cod = Console.ReadLine();
                        Empilhar();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Informe o codigo");
                        Cod = Console.ReadLine();
                        Remove();
                        Console.ReadLine();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void Empilhar()
        {
            bool empilha = false;
            int pos = 0;
            int menor = 5;
            for (x = 0; x < 4; x++)
            {
                if (cont[x] < menor)
                {
                    menor = cont[x];
                    pos = x;
                }
            }
            switch (pos)
            {
                case 0:
                    Console.WriteLine("Local 1");
                    foreach(var item in Local1)
                    {
                        if(string.Compare(item,Cod)==0)
                        {
                            empilha = true;
                        }
                    }
                    if(empilha == false)
                    {
                        if(Local1.Count > 3)
                        {
                            Console.WriteLine("Local cheio");
                        }else
                            Local1.Push(Cod);
                    }
                    else
                        Console.WriteLine("Codigo ja existe");
                    break;
                case 1:
                    Console.WriteLine("Local 2");
                    foreach (var item in Local2)
                    {
                        if (string.Compare(item, Cod) == 0)
                        {
                            empilha = true;
                        }
                    }
                    if (empilha == false)
                    {
                        if (Local2.Count > 3)
                        {
                            Console.WriteLine("Local cheio");
                        }
                        else
                            Local2.Push(Cod);
                    }
                    else
                        Console.WriteLine("Codigo ja existe");
                    break;
                case 2:
                    Console.WriteLine("Local 3");
                    foreach (var item in Local3)
                    {
                        if (string.Compare(item, Cod) == 0)
                        {
                            empilha = true;
                        }
                    }
                    if (empilha == false)
                    {
                        if (Local3.Count > 3)
                        {
                            Console.WriteLine("Local cheio");
                        }
                        else
                            Local3.Push(Cod);
                    }
                    else
                        Console.WriteLine("Codigo ja existe");
                    break;
                case 3:
                    Console.WriteLine("Local 4");
                    foreach (var item in Local4)
                    {
                        if (string.Compare(item, Cod) == 0)
                        {
                            empilha = true;
                        }
                    }
                    if (empilha == false)
                    {
                        if (Local4.Count > 3)
                        {
                            Console.WriteLine("Local cheio");
                        }
                        else
                            Local4.Push(Cod);
                    }
                    else
                        Console.WriteLine("Codigo ja existe");
                    break;
            }

        }


        public void Remove()
        {
            if (Local1.Contains(Cod) == true)
            {
                if (string.Compare(Local1.Peek(), Cod) == 0)
                {
                    Console.WriteLine("Local 1, removido");
                    Local1.Pop();
                }
                else
                    Console.WriteLine("Nao esta no topo");
            }
            else if (Local2.Contains(Cod) == true)
            {
                if (string.Compare(Local2.Peek(), Cod) == 0)
                {
                    Console.WriteLine("Local 2, removido");
                    Local1.Pop();
                }
                else
                    Console.WriteLine("Nao esta no topo");
            }
            else if (Local3.Contains(Cod) == true)
            {
                if (string.Compare(Local3.Peek(), Cod) == 0)
                {
                    Console.WriteLine("Local 3, removido");
                    Local1.Pop();
                }
                else
                    Console.WriteLine("Nao esta no topo");
            }
            else if (Local4.Contains(Cod) == true)
            {
                if (string.Compare(Local4.Peek(), Cod) == 0)
                {
                    Console.WriteLine("Local 4, removido");
                    Local1.Pop();
                }
                else
                    Console.WriteLine("Nao esta no topo");
            }
            else
                Console.WriteLine("Nao encontrado");
        }
    }
}
