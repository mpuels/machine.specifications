﻿namespace Machine.Specifications.Runner
{
    using System.Xml.Linq;

    public static class ContextInfoExtensions
    {
        public static string ToXml(this ContextInfo contextInfo)
        {
            return
                new XElement(
                    "contextinfo",
                    new XElement("name", contextInfo.Name),
                    new XElement("concern", contextInfo.Concern),
                    new XElement("typename", contextInfo.TypeName),
                    new XElement("namespace", contextInfo.Namespace),
                    new XElement("assemblyname", contextInfo.AssemblyName),
                    new XElement("assemblyname", contextInfo.AssemblyName),
                    new XElement("fullname", contextInfo.FullName),
                    new XElement("captureoutput", contextInfo.CapturedOutput))
                .ToString();
        }
    }
}