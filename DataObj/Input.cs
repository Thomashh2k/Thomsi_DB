using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Headless.DB.DataObj
{
    public class Input
    {
        public string InputName { get; set; }
        public long? InputLength { get; set; }
        public bool NotNullable { get; set; }
        public InputType InputType { get; set; }

        public string ToSQLColumn()
        {
            return InputName + ' ' + ToPgsqlType(InputType) + ' ';
            
        }

        public static string ToPgsqlType(InputType type)
        {
            if (type == InputType.text ||
               type == InputType.password ||
               type == InputType.tel ||
               type == InputType.file ||
               type == InputType.image ||
               type == InputType.email)
            {
                return "TEXT";
            }
            else if (type == InputType.checkbox)
                return "BOOLEAN";
            else if (type == InputType.date)
                return "TIMESTAMP";
            else if (type == InputType.time)
                return "TIME";

            throw new Exception("Input Type couldnt be converted");
        }


        
        public static Input DeserializeInput(string serializedInput)
        {
            return JsonSerializer.Deserialize<Input>(serializedInput);
            
        }
    }

    public enum InputType 
    {
        text = 0,
        tel = 1,
        email = 2,
        checkbox = 3,
        file = 4,
        image = 5,
        password = 6,
        date = 7,
        time = 8,
        color = 9,
    }
}
