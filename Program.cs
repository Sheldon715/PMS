using PMS.Models;
using PMS.Enums;

PaintSpecification paintSpecification1 = new PaintSpecification("White", 10);
PaintProduct paintProduct1 = new PaintProduct("dulux", PaintType.Matte, paintSpecification1, 50);
PaintSpecification paintSpecification2 = new PaintSpecification("Black", 10);
PaintProduct paintProduct2 = new PaintProduct("simple", PaintType.Basecoast, paintSpecification2, 30);

paintProduct1.DisplayInfo();

Order order1 = new Order([paintProduct1, paintProduct2], [10, 20]);

order1.DisplayOrder();