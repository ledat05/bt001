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
                public void DeleteNote(int x)
                {
                    Node p = Head;
                    Node q = null;
                        while (p!=null && p.info !=x)
                    {
                        q = p;
                        p = p.Next;
                    }
                        if(p !=null)
                    {
                        if (p == Head)
                            DeleteHead();
                        else
                        {
                            q.Next = p.Next;
                            p.Next = null;
                        }
                    }
                }
                public Node FindMax()
                {

                    Node max = Head;
                    Node p = Head.next;

                    while (p != null)
                    {
                        if (p.info > max.info)
                        {
                            max = p;
                        }

                        p = p.next;
                    }

                    return max;
                }

                public float TinhTrungBinh()
                {
                    float sum = 0;
                    float dem = 0;
                    Node p = Head;
                    while(p!=null)
                    {
                        sum +=p.info;
                        dem++;
                        p = p.next;

                    }
                    
                        if (dem==0)
                    {
                        return 0;
                    }
                    return sum / dem;

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
                    NhapDanhSach(l);
                    Console.WriteLine("Danh sach lien ket duoc tao:");

                    l.Xuat();

                    l.DeleteHead();
                    Console.WriteLine("Danh sach lien ket sau khi xoa nut dau:");
                    l.Xuat();

                    l.Deletelast();
                    Console.WriteLine("Danh sach lien ket sau khi xoa nut cuoi:");
                    l.Xuat();

                    
                    Console.WriteLine("$Nhap gia tri x can xoa");
                    int     x = int.Parse(Console.ReadLine());
                    l.DeleteNote(x);
                    Console.Write("\n Danh sach lien ket sau khi xoa nut co gia tri:");
                    l.Xuat();

                    Node max = l.FindMax();
                    Console.WriteLine ($"Nut co gia tri lon nhat: { max.info}");

                    float average = l.TinhTrungBinh();
                    Console.WriteLine("Diem Trung Binh: " + average);
                    l.Xuat();

                    Console.ReadLine();
                }
                static void NhapDanhSach(DSLienKetDon l)
                {
                    string chon = "y";
                    int x;
                    while (chon!="n")
                    {
                        Console.WriteLine("Nhap gia tri nut");
                        x = int.Parse(Console.ReadLine());
                        l.Addlast(x);
                        Console.Write("Tiep tuc (y/n)?");
                        chon = Console.ReadLine();
                    }
                }
            }
        }
    }
}
