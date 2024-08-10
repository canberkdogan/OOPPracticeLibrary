using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticeLibrary
{
    public class Library
    {
        public string _bookName;
        public string _authorName;
        public string _authorSurname;
        public int _pageNum;
        public string _publisher;

        public DateTime _logDate;


        public string Bookname
        {
            get
            {
                return _bookName;
            }


            set
            {
                _bookName = value;
            }

        }

        public string AuthorName 
        
        {
            get

            {
                return _authorName;
            }

            set
            {
                _authorName = value;
            }


        
        }


        public string AuthorSurname
        {
            get 
            
            {
                return _authorSurname;
            
            }

            set
            {
                _authorSurname = value;
            }
        }
        public int PageNum

        {
            get
            {
                return _pageNum;
            }



            set
            {
                _pageNum = value;
            }
        }

            public string Publisher
        {

            get
            {
                return _publisher;
            }


            set
            {
                _publisher = value;
            }


        }

            public Library()
        {
            Date();
        }


        public Library(string bookName, string authorName, string authorSurname,int pageNum, string publisher)
        {
            _bookName=bookName;
            _authorName=authorName; 
            _authorSurname=authorSurname;
            _pageNum = pageNum;
            _publisher=publisher;

        }

        public void Date()
        {
            _logDate=DateTime.Now;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Book Name: {_bookName}\nAuthor Name: {_authorName}\nAuthorSurname: {_authorSurname}\nPage Number: {_pageNum}\nPublisher: {_publisher}\n" );
        }



    }

    }

