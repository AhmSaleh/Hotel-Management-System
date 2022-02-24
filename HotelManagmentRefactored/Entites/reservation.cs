using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentRefactored.Entites
{
    public class reservation
    {
        //[Id] [int] IDENTITY(1011,1) NOT NULL,
        [Key]
        public int ID { get; set; }

        //[first_name] [nvarchar](50) NOT NULL,
        [MaxLength(50), Required]
        public string? first_name { get; set; }

        //[last_name] [nvarchar] (50) NOT NULL,
        [MaxLength(50)]
        public string last_name { get; set; }

        //[birth_day] [nvarchar](50) NOT NULL,
        [MaxLength(50)]
        public string birth_day { get; set; }

        //[gender] [nvarchar](50) NOT NULL,
        [MaxLength(50)]
        public string gender { get; set; }

        //[phone_number] [nvarchar](50) NOT NULL,
        [MaxLength(50)]
        public string phone_number { get; set; }

        //[email_address] [nvarchar] (max) NOT NULL,

        public string email_address { get; set; }

        //[number_guest] [int] NOT NULL,
        public int number_guest { get; set; }

        //[street_address] [nvarchar](max) NOT NULL,
        public string street_address { get; set; }

        //[apt_suite] [nvarchar](50) NOT NULL,
        [MaxLength(50)]
        public string apt_suite { get; set; }

        //[city] [nvarchar](max) NOT NULL,
        public string city { get; set; }

        //[state] [nvarchar](50) NOT NULL,
        [MaxLength(50)]
        public string state { get; set; }

        //[zip_code] [nchar](10) NOT NULL,
        [MaxLength(10)]
        public string zip_code { get; set; }

        //[room_type] [nchar](10) NOT NULL,
        [MaxLength(10)]
        public string room_type { get; set; }

        //[room_floor] [nchar](10) NOT NULL,
        [MaxLength(10)]
        public string room_floor { get; set; }

        //[room_number] [nchar](10) NOT NULL,
        [MaxLength(10)]
        public string room_number { get; set; }

        //[total_bill] [float] NOT NULL,
        public double total_bill { get; set; }

        //[payment_type] [nchar](10) NOT NULL,
        [MaxLength(10)]
        public string payment_type { get; set; }

        //[card_type] [nchar](10) NOT NULL,
        [MaxLength(10)]
        public string card_type { get; set; }

        //[card_number] [nvarchar](50) NOT NULL,
        [MaxLength(50)]
        public string card_number { get; set; }

        //[card_exp] [nvarchar](50) NOT NULL,
        [MaxLength(50)]
        public string card_exp { get; set; }

        //[card_cvc] [nchar](10) NOT NULL,
        [MaxLength(10)]
        public string card_cvc { get; set; }

        //[arrival_time] [date] NOT NULL,
        public DateTime arrival_time { get; set; }

        //[leaving_time] [date] NOT NULL,
        public DateTime leaving_time { get; set; }

        //[check_in] [bit] NOT NULL,
        public bool check_in { get; set; }

        //[break_fast] [int] NOT NULL,
        public int break_fast { get; set; }

        //[lunch] [int] NOT NULL,
        public int lunch { get; set; }

        //[dinner] [int] NOT NULL,
        public int dinner { get; set; }

        //[cleaning] [bit] NOT NULL,
        public bool cleaning { get; set; }

        //[towel] [bit] NOT NULL,
        public bool towel { get; set; }

        //[s_surprise] [bit] NOT NULL,
        public bool s_surprise { get; set; }

        //[supply_status] [bit] NOT NULL,
        public bool supply_status { get; set; }

        //[food_bill] [int] NOT NULL,
        public int food_bill { get; set; }
    }
}
