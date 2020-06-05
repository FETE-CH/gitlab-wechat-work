using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace wechat_robot.Models {
    [Table("user")]
    public class User {
        [Key]
        [Column("uid")]
        public int? Uid { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("creat_time")]
        public DateTime? CreatTime { get; set; }

        [Column("update_time")]
        public DateTime? UpdateTime { get; set; }
    }
}