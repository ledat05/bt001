using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    class Program
    {
        class Node
        {
            private int info;
            private Node next;
            public Node(int x)
            {
                info = x;
                next = null;
            }
            public int Info
            {
                set { info = value; }
                get { return info; }
            }
            public Node Next
            {
                set { next = value; }
                get { return next; }
            }
            class DSLienKetDon
            {
                private Node Head;
                public DSLienKetDon()
                {
                    Head = null;
                }
                public void AddHead(int x)
                {
                    Node p = new Node(x);
                    p.next = Head;
                    Head = p;
                }
                public void Addlast(int x)
                {
                    Node p = new Node(x);
                    if(Head==null)
                    {
                        Head = p;
                    }    
                    else
                    {
                        Node q = Head;
                        while (q.Next != null)
                        {
                            q = q.Next;
                        }
                        q.Next = p;
                            
                    }    
                }
                public void DeleteHead()
                {
                    Node p = Head;
                    Head = Head.Next;
                    p.Next = null; 
                }
                public void Deletelast()
                {
                    if(Head!=null)
                    {
                        Node p = Head;
                        Node q = null;
                        while(p.Next !=null)
                        {
                            q = p;
                            p = p.Next;
                        }
                        q.Next = null;
                    }    

                }
                public void  Xuat()
                {
                    Node p = Head;
                    while(p!=null)
                    {
                        Console.WriteLine($"{p.info} ");
                        p = p.Next;
                    }    
                }
                static void Main(string[] args)
                {
                    DSLienKetDon l = new DSLienKetDon();
                    l.AddHead(9);
                    l.AddHead(7);
                    l.AddHead(8);
                    l.Addlast(5);
                    l.AddHead(10);
                    l.Addlast(1);
                    Console.WriteLine("Danh sach lien ket duoc tao:");

                    l.Xuat();

                    l.DeleteHead();
                    Console.WriteLine("Danh sach lien ket sau khi xoa nut dau:");
                    l.Xuat();

                    l.Deletelast();
                    Console.WriteLine("Danh sach lien ket sau khi xoa nut cuoi:");
                    l.Xuat();
                    Console.ReadLine();
                }
            }
        }
    }
}
