using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

using meta.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using meta.Views;
using System.Linq;

namespace meta
{
    [Table("Chapters")]
    public class Note
    {
        static int count = 1;
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; } = count;
        public string Title { get; set; }
        public string Text { get; set; }
        public Note()
        {
            count++;
        }
    }
}
