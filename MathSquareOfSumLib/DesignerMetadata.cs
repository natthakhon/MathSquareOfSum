using System;
using System.Activities.Presentation.Metadata;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSquareOfSumLib
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            AttributeTableBuilder attributeTableBuilder = new AttributeTableBuilder();
            attributeTableBuilder.AddCustomAttributes(typeof(MathSqSum), new DesignerAttribute(typeof(MathSqSumDesigner)));
            MetadataStore.AddAttributeTable(attributeTableBuilder.CreateTable());
        }
    }
}
