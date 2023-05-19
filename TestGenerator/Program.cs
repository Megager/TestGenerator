﻿using System.Text;

StringBuilder sb = new StringBuilder();

sb.AppendLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
sb.AppendLine();

sb.AppendLine("namespace Test");
sb.AppendLine("{");

sb.AppendLine("[TestClass]");
sb.AppendLine("public class AutoGeneratedTests");
sb.AppendLine("{");

for (int i = 0; i < 5000; i++)
{
    sb.AppendLine($"\t[TestMethod]");
    sb.AppendLine($"\tpublic void TestMethod{i}()");
    sb.AppendLine("\t{");
    sb.AppendLine("\t\tAssert.AreEqual(5+6, 11);"); // Replace this with actual test logic.
    sb.AppendLine("\t}");
    sb.AppendLine();
}
sb.AppendLine("}");
sb.AppendLine("}");

File.WriteAllText("test.cs", sb.ToString());
