using System.Xml.Linq;
using System.Data;


namespace Tagtool.Services
{
    public class SD_XML
    {

        //public void ReadIntoDatabase(string sFile, string sDB, int iCountMode)
        //{
        //    string sName;
        //    string sType;
        //    string sStruct;
        //    string SQL;
        //    int iWordCount = 0;
        //    int iBoolCount = 0;

        //    if (File.Exists(sFile))
        //    {
        //        XDocument doc = XDocument.Load(sFile);

        //        try
        //        {
        //            conn.Open();

        //            if (conn.State == System.Data.ConnectionState.Open)
        //            {

        //                sStruct = doc.Descendants("{http://www.plcopen.org/xml/tc6_0201}dataType").First().Attribute("name").Value.ToString();

        //                SQL = "DELETE FROM FunctionBlockDetails WHERE BlockName = @a";
        //                OleDbCommand add = new OleDbCommand();

        //                add.CommandText = SQL;
        //                add.Connection = conn;
        //                add.Parameters.AddWithValue("@a", sStruct);
        //                add.ExecuteNonQuery();


        //                var elements = doc.Descendants("{http://www.plcopen.org/xml/tc6_0201}variable");

        //                foreach (var e in elements)
        //                {
        //                    sName = e.Attribute("name").Value;

        //                    sType = e.Element("{http://www.plcopen.org/xml/tc6_0201}type").FirstNode.ToString();

        //                    sType = sType.Substring(1, sType.Length - 1);
        //                    sType = sType.Substring(0, sType.IndexOf(" "));

        //                    switch (sType)
        //                    {
        //                        case "INT":
        //                            iWordCount += 1;
        //                            if (iCountMode == 1) iBoolCount = 0;
        //                            break;

        //                        case "BOOL":
        //                            if (iBoolCount == 0) iWordCount += 1;
        //                            iBoolCount += 1;
        //                            if (iBoolCount >= 16) iBoolCount = 0;
        //                            break;

        //                        case "DINT":
        //                            iWordCount += 2;
        //                            if (iCountMode == 1) iBoolCount = 0;
        //                            break;
        //                        case "REAL":
        //                            iWordCount += 2;
        //                            if (iCountMode == 1) iBoolCount = 0;
        //                            break;
        //                    }

        //                    add = new OleDbCommand();

        //                    SQL = "INSERT INTO FunctionBlockDetails (BlockName, VariableName, DataType) VALUES(@a, @b, @c)";

        //                    add.CommandText = SQL;
        //                    add.Connection = conn;
        //                    add.Parameters.AddWithValue("@a", sStruct);
        //                    add.Parameters.AddWithValue("@b", sName);
        //                    add.Parameters.AddWithValue("@c", sType);
        //                    add.ExecuteNonQuery();

        //                }


        //                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM FunctionBlocks WHERE FunctionBlockName = '" + sStruct + "'", conn);

        //                DataSet ds = new DataSet();
        //                da.Fill(ds);

        //                if (ds.Tables[0].Rows.Count > 0)
        //                {
        //                    SQL = "UPDATE Functionblocks SET DataLength = " + iWordCount.ToString() + " WHERE FunctionBlockName = '" + sStruct + "'";
        //                    add.CommandText = SQL;
        //                    add.Connection = conn;

        //                    add.ExecuteNonQuery();
        //                }
        //                else
        //                {
        //                    SQL = "INSERT INTO FunctionBlocks(FunctionBlockName, DataLength, ScalingNeeded) VALUES(@b,@Length,0)";
        //                    add.CommandText = SQL;
        //                    add.Connection = conn;
        //                    add.Parameters.AddWithValue("@Length", iWordCount);
        //                    add.Parameters.AddWithValue("@b", sStruct);
        //                    add.ExecuteNonQuery();
        //                }

        //            }

        //            conn.Close();
        //        }

        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }

        //    }

        //}

        public void ExportToXML(string sPath, string sStruct, List<(string, string, string)> variables)
        {

            string sVariable;
            string sDatatype;
            string sComment;

            int iLineNumber = 1;

            XNamespace NS0 = "http://www.plcopen.org/xml/tc6_0201";
            XNamespace NSComment = "http://www.w3.org/1999/xhtml";

            try
            {
                if (sPath != "")
                {
                    string sFile = sPath + "\\" + sStruct + ".xml";

                    XDocument doc = new XDocument(
                                        new XElement(NS0 + "project",
                                            new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                                            new XAttribute(XNamespace.Xmlns + "xsd", "http://www.w3.org/2001/XMLSchema"),
                                            new XElement(NS0 + "fileHeader",
                                                new XAttribute("companyName", "MITSUBISHI ELECTRIC CORPORATION"),
                                                new XAttribute("companyURL", "http://www.mitsubishielectric.com"),
                                                new XAttribute("productName", "GX Works3"),
                                                new XAttribute("productVersion", "1.076E"),
                                                new XAttribute("creationDateTime", "2021-10-18T16:51:29+02:00")
                                            ),
                                            new XElement(NS0 + "contentHeader",
                                                new XAttribute("name", "Dummy"),
                                                new XAttribute("modificationDateTime", "2021-08-20T11:15:49+02:00"),
                                                new XElement(NS0 + "coordinateInfo",
                                                    new XElement(NS0 + "fbd",
                                                        new XElement(NS0 + "scaling",
                                                            new XAttribute("x", "1"),
                                                            new XAttribute("y", "1")
                                                        )
                                                    ),
                                                    new XElement(NS0 + "ld",
                                                        new XElement(NS0 + "scaling",
                                                            new XAttribute("x", "1"),
                                                            new XAttribute("y", "1")
                                                        )
                                                    ),
                                                    new XElement(NS0 + "sfc",
                                                        new XElement(NS0 + "scaling",
                                                            new XAttribute("x", "1"),
                                                            new XAttribute("y", "1")
                                                        )
                                                    )
                                                )
                                            ),
                                            new XElement(NS0 + "types",
                                                new XElement(NS0 + "dataTypes",
                                                    new XElement(NS0 + "dataType",
                                                        new XAttribute("name", sStruct),
                                                        new XElement(NS0 + "baseType",
                                                            new XElement(NS0 + "struct")
                                                        ),
                                                        new XElement(NS0 + "addData",
                                                            new XElement(NS0 + "data",
                                                                new XAttribute("name", "http://www.mitsubishielectric.com/xml/dataTypeProperties"),
                                                                new XAttribute("handleUnknown", "implementation"),
                                                                new XElement(NS0 + "dataTypeProperties",
                                                                    new XAttribute("modificationDateTime", "2021-08-17T09:15:25+02:00")
                                                                )
                                                            )
                                                        )
                                                    )
                                                ),
                                                new XElement(NS0 + "pous")
                                            ),
                                            new XElement(NS0 + "instances",
                                                new XElement(NS0 + "configurations")
                                            ),
                                            new XElement(NS0 + "addData",
                                                new XElement(NS0 + "data",
                                                    new XAttribute("name", "http://www.mitsubishielectric.com/xml/projectPlcType"),
                                                    new XAttribute("handleUnknown", "implementation"),
                                                    new XElement(NS0 + "projectPlcType",
                                                        new XAttribute("name", "R08")
                                                    )
                                                ),
                                                new XElement(NS0 + "data",
                                                    new XAttribute("name", "http://www.mitsubishielectric.com/xml/projectLabelArea"),
                                                    new XAttribute("handleUnknown", "implementation"),
                                                    new XElement(NS0 + "projectLabelArea",
                                                        new XAttribute("labelAreaTopOffset", "102400"),
                                                        new XAttribute("latchAreaTopOffset", "204800")
                                                    )
                                                )
                                            )
                                        )
                        );





                    var StructNode = doc.Descendants(NS0 + "struct").FirstOrDefault();

                    foreach ((string, string, string) sData in variables)
                    {
                        sVariable = sData.Item1;
                        sDatatype = sData.Item2;
                        sComment = sData.Item3;

                        StructNode.Add(new XElement(NS0 + "variable",
                                            new XAttribute("name", sVariable),
                                            new XElement(NS0 + "type",
                                                new XElement(NS0 + sDatatype)
                                            ),
                                            new XElement(NS0 + "addData",
                                                new XElement(NS0 + "data",
                                                    new XAttribute("name", "http://www.mitsubishielectric.com/xml/variableLineNumber"),
                                                    new XAttribute("handleUnknown", "implementation"),
                                                    new XElement(NS0 + "variableLineNumber",
                                                        new XAttribute("number", iLineNumber.ToString())
                                                    )
                                                ),
                                                new XElement(NS0 + "data",
                                                    new XAttribute("name", "http://www.mitsubishielectric.com/xml/variableComments"),
                                                    new XAttribute("handleUnknown", "implementation"),
                                                    new XElement(NS0 + "variableComments",
                                                        new XElement(NS0 + "comment",
                                                            new XAttribute("number", "7"),
                                                            new XElement(NSComment + "html",
                                                                new XAttribute(XNamespace.Xml + "space", "preserve"),
                                                                new XText(sComment)
                                                            )
                                                        )
                                                    )
                                                )
                                            )
                                        )
                            );

                        iLineNumber += 1;

                    }

                    doc.Declaration = new XDeclaration("1.0", "utf-16", null);

                    doc.Save(sFile);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

    public class Label_XML
    {
        private string XMLPath;
        private int LastUsedInternalAdress;
        private int LineNumber;
        public Label_XML(string SavePath)
        {
            XMLPath = SavePath;
            LastUsedInternalAdress = 19000;
            LineNumber = 1;
        }

        public void GenerateNewFile()
        {
            XNamespace NS0 = "http://www.plcopen.org/xml/tc6_0201";

            XDocument doc = new XDocument(
                new XElement(NS0 + "project",
                    new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                    new XAttribute(XNamespace.Xmlns + "xsd", "http://www.w3.org/2001/XMLSchema"),
                    new XElement(NS0 + "fileHeader",
                        new XAttribute("companyName", "MITSUBISHI ELECTRIC CORPORATION"),
                        new XAttribute("companyURL", "http://www.mitsubishielectric.com"),
                        new XAttribute("productName", "GX Works3"),
                        new XAttribute("productVersion", "1.076E"),
                        new XAttribute("creationDateTime", "2021-10-18T16:50:34+02:00")
                    ),
                    new XElement(NS0 + "contentHeader",
                        new XAttribute("name", "Dummy"),
                        new XAttribute("modificationDateTime", "2021-10-18T16:50:16+02:00"),
                        new XElement(NS0 + "coordinateInfo",
                            new XElement(NS0 + "fbd",
                                new XElement(NS0 + "scaling",
                                    new XAttribute("x", "1"),
                                    new XAttribute("y", "1")
                                )
                            ),
                            new XElement(NS0 + "ld",
                                new XElement(NS0 + "scaling",
                                    new XAttribute("x", "1"),
                                    new XAttribute("y", "1")
                                )
                            ),
                            new XElement(NS0 + "sfc",
                                new XElement(NS0 + "scaling",
                                    new XAttribute("x", "1"),
                                    new XAttribute("y", "1")
                                )
                            )
                        )
                    ),
                    new XElement(NS0 + "types",
                        new XElement(NS0 + "dataTypes"),
                        new XElement(NS0 + "pous")
                    ),
                    new XElement(NS0 + "instances",
                        new XElement(NS0 + "configurations",
                            new XElement(NS0 + "configuration",
                                new XAttribute("name", ""),
                                new XElement(NS0 + "globalVars",
                                    new XAttribute("name", "Tagtool"),
                                    new XElement(NS0 + "addData",
                                        new XElement(NS0 + "data",
                                            new XAttribute("name", "http://www.mitsubishielectric.com/xml/varListProperties"),
                                            new XAttribute("handleUnknown", "implementation"),
                                            new XElement(NS0 + "varListProperties",
                                                new XAttribute("modificationDateTime", "2021-10-18T16:50:16+02:00")
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    ),
                    new XElement(NS0 + "addData",
                        new XElement(NS0 + "data",
                            new XAttribute("name", "http://www.mitsubishielectric.com/xml/projectPlcType"),
                            new XAttribute("handleUnknown", "implementation"),
                            new XElement(NS0 + "projectPLCType",
                                new XAttribute("name", "R08")
                            )
                        ),
                        new XElement(NS0 + "data",
                            new XAttribute("name", "http://www.mitsubishielectric.com/xml/projectLabelArea"),
                            new XAttribute("handleUnknown", "implementation"),
                            new XElement(NS0 + "projectLabelArea",
                                new XAttribute("labelAreaTopOffset", "102400"),
                                new XAttribute("latchAreaTopOffset", "204800")
                            )
                        )
                    )
                )

            );

            doc.Declaration = new XDeclaration("1.0", "utf-16", null);

            doc.Save(XMLPath);
        }

        public void AddStruct(string sName, string sStruct, string sComment, List<(string, string)> variables)
        {


            XNamespace NS0 = "http://www.plcopen.org/xml/tc6_0201";
            XNamespace NSComment = "http://www.w3.org/1999/xhtml";

            if (File.Exists(XMLPath))
            {
                XDocument doc = XDocument.Load(XMLPath);

                var GlobalVars = doc.Descendants(NS0 + "globalVars").FirstOrDefault();

                if (GlobalVars != null)
                {
                    GlobalVars.Add(new XElement(NS0 + "variable",
                                        new XAttribute("name", sName),
                                        new XAttribute("address", "GV:" + LastUsedInternalAdress.ToString()),
                                        new XElement(NS0 + "type",
                                            new XElement(NS0 + "derived",
                                                new XAttribute("name", sStruct)
                                            )
                                        ),
                                        new XElement(NS0 + "addData",
                                            new XElement(NS0 + "data",
                                                new XAttribute("name", "http://www.mitsubishielectric.com/xml/variableLineNumber"),
                                                new XAttribute("handleUnknown", "implementation"),
                                                new XElement(NS0 + "variableLineNumber",
                                                    new XAttribute("number", LineNumber.ToString())
                                                )
                                            ),
                                            new XElement(NS0 + "data",
                                                new XAttribute("name", "http://www.mitsubishielectric.com/xml/variableComments"),
                                                new XAttribute("handleUnknown", "implementation"),
                                                new XElement(NS0 + "variableComments",
                                                    new XElement(NS0 + "comment",
                                                        new XAttribute("number", "7")
                                                    )
                                                )
                                            ),
                                            new XElement(NS0 + "data",
                                                new XAttribute("name", "http://www.mitsubishielectric.com/xml/variableStructDeviceAssignment"),
                                                new XAttribute("handleUnknown", "implementation"),
                                                new XElement(NS0 + "variableStructDeviceAssignment")
                                            )
                                        )
                                    )

                        );

                    LineNumber += 1;

                    if (sComment != "")
                    {
                        var CommentNode = GlobalVars.Descendants(NS0 + "variable")
                            .Where(x => (x.Attribute("name").Value == sName))
                            .Select(x => (x.Element(NS0 + "addData")))
                            .SingleOrDefault();



                        if (CommentNode != null)
                        {
                            CommentNode = CommentNode.Descendants(NS0 + "comment").FirstOrDefault();

                            if (CommentNode != null)
                            {
                                CommentNode.Add(new XElement(NSComment + "html",
                                                new XAttribute(XNamespace.Xml + "space", "preserve"),
                                                new XText(sComment)
                                            )
                                );
                            }

                        }

                    }

                    var StructNode = GlobalVars.Descendants(NS0 + "variable")
                            .Where(x => (x.Attribute("name").Value == sName))
                            .Select(x => (x.Element(NS0 + "addData")))
                            .SingleOrDefault();

                    if (StructNode != null)
                    {
                        StructNode = StructNode.Descendants(NS0 + "variableStructDeviceAssignment").FirstOrDefault();

                        if (StructNode != null)
                        {
                            string sVariable, sAddress;

                            foreach ((string, string) sData in variables)
                            {
                                sVariable = sData.Item1;
                                sAddress = sData.Item2;

                                StructNode.Add(new XElement(NS0 + "member",
                                                    new XAttribute("name", sVariable),
                                                    new XAttribute("address", sAddress)
                                                )
                                    );
                            }
                        }

                    }

                    doc.Save(XMLPath);
                }
            }


        }

    }

}