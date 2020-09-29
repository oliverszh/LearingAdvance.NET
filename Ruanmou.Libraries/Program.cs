using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Libraries
{
    /// <summary>
    /// 解决方案搜索 Eleven，查看项目注意点
    /// 
    /// 高级班的传统，准备好学习的小伙伴儿，给Eleven老师刷个字母E，然后课程就要正式开始啦。。。不等人啊不等人
    /// 
    /// Eleven  
    /// 项目分层：UI控制台--数据库访问层---数据库访问层抽象---Model---Framework
    /// 
    /// 把更新&删除实现一下，
    /// 把生成器做个单独项目，winform，配置下模板就更好
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Eleven直播写作业了。。。。");
                //where id=1 or name="" and name like    

                string name = "Eleven' OR 1=1;--";
                string sql = $"SELECT * FROM [USER] WHERE NAME='{name}' AND PASSWORD='12345'";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
