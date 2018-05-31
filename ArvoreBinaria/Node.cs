using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    class Node
    {
        Node nodeLeft;
        Node nodeRight;
        Node pai;
        int valor { get; set; }
        public static Node root;

        public Node(int v)
        {
            this.valor = v;
        }
        public Node(int v, Node pai)
        {
            this.valor = v;
            this.pai = pai;
        }

        public static void insert(int v)
        {
            insert(root, v);
        }

        public static void insert(Node node, int v)
        {
            if (node == null)
            {
                root = new Node(v);
            }
            else
            {
                if (v < node.valor)
                {
                    if (node.nodeLeft != null)
                    {
                        insert(node.nodeLeft, v);
                    }
                    else
                    {
                        node.nodeLeft = new Node(v, node);
                        Console.WriteLine("inserido " + v + " a esquerda de " + node.valor);
                        Console.WriteLine("Pai de " + v + ": " + node.valor);
                    }
                }
                else
                {
                    if (node.nodeRight != null)
                    {
                        insert(node.nodeRight, v);
                    }
                    else
                    {
                        node.nodeRight = new Node(v, node);
                        Console.WriteLine("inserido " + v + " a direita de " + node.valor);
                        Console.WriteLine("Pai de " + v + ": " + node.valor);
                    }
                }
            }
        }

        public static string preOrdem(Node node)
        {
            StringBuilder sb = new StringBuilder();
            if (node != null)
            { 
                sb.Append(node.valor);
                sb.Append(", ");
                sb.Append(preOrdem(node.nodeLeft));
                sb.Append(preOrdem(node.nodeRight));               
            }
            return sb.ToString();
        }

        public static string posOrdem(Node node)
        {
            StringBuilder sb = new StringBuilder();
            if (node != null)
            {
                sb.Append(posOrdem(node.nodeLeft));
                sb.Append(posOrdem(node.nodeRight));                
                sb.Append(node.valor);
                sb.Append(", ");    
            }
            return sb.ToString();
        }



    }
}
