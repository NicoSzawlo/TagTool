using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Services
{
    //Class for generating Addresslists for different address counting systems
    //Needed for alarmlist so address can be displayed in the text
    public class AddressListGenerator
    {
        //Generates a list of strings resembling an addresslist in a memory system that is 
        //Addressed via decimal numbers
        public static List<string> DecimalList(string startAddress, int size, string prefix)
        {
            List<string> addressList = new List<string>();
            for(int i = 0; i < size; i++)
            {
                addressList.Add(prefix + (Convert.ToInt64(startAddress) + i).ToString());
            }
            return addressList;
        }
        //Generates a List of strings which resembles a addresslist in a memory area
        //that is addressed via a hexadecimal address-system (e.g. Mitsubishi PLC's)
        public static List<string> HexList(string startAddress, int size, string prefix)
        {
            List<string> addressList = new List<string>();
            List<int> numberList = new List<int>();
            int temp = 0;
            for(int i = 0; i < size; i++)
            {
                temp = int.Parse(startAddress, System.Globalization.NumberStyles.HexNumber);
                temp += i;
                addressList.Add(prefix + temp.ToString("X"));
            }
            return addressList;
        }
        //Generates a list of strings which resembles an bit-address list in a memory system 
        //where "Words" are addressed via decimal, and only the bitaddress is addressed via HEX
        public static List<string> MixList(string startAddress, int size, string prefix)
        {
            List<string> addressList = new List<string>();
            //Get "start address" of the hexadecimal portion of the startaddress, startaddress of the bits
            string hexPart = startAddress.Substring(startAddress.Length - 1);
            //Get "start address" of the decimal portion of the startaddress
            string decPart = startAddress.Substring(0, startAddress.Length - 1);
            //Calculate the number of loops for the decimal portion
            int decSize = size / 16;

            int index = 0;
            //Check if size is greater/equal to 16 (smaller doesnt make sense)
            if(size >= 16)
            {
                //Go through each step of the decimal portion size
                for (int i = 0; i <= decSize; i++)
                {
                    //Go through number of bits in a word
                    for (int j = 0; j < 16; j++)
                    {
                        //Check if first in list, then set the start-bitaddress as index for loop
                        if(index == 0)
                        {
                            j = int.Parse(hexPart, System.Globalization.NumberStyles.HexNumber);
                        }
                        //Check if index is smaller than size and add addressstring to list
                        if(index < size)
                        {
                            //Addressstring =
                            //Prefix +
                            //(Startaddress of decimal portion + decimal loop index) +
                            //Index of bit-address loop converted to HEX
                            addressList.Add(prefix + (i + int.Parse(decPart)).ToString() + j.ToString("X"));
                            index++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return addressList;
        }
    }
}
