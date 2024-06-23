// See https://aka.ms/new-console-template for more information
using EntityFrameworkPractice.Models;
using EntityFrameworkPractice;
using EntityFrameworkPractice.Data;
using EntityFrameworkPractice.Querys;

/*Supplier supplier = new Supplier
{
    Name = "Teszt Szup 1",
    GLN = "1111111111222",
    TaxID = "1111-22-33",
    AccountNumber = "11111111-22222222-33333333",
    CodeByBuyer = "11112222",
    PublicAreaName = "Teszt utca 1.",
    CityName = "Teszt város",
    PostalCode = "1234",
    Country = "HU"
};

Retailer retailer = new Retailer
{
    Name = "Teszt Ret 1",
    GLN = "2111111111222",
    TaxID = "2111-22-33",
    PublicAreaName = "Teszt utca 2.",
    CityName = "Teszt város 2",
    PostalCode = "2234",
    Country = "HU"
};

Order order = new Order
{
    OrderNumber = "12345",
    SupplierILN = "1111111111222",
    OrderCreationDate = DateTime.Now,
    OrderCurrency = "HUF",
    TargetCurrency = "HUF",
    OrderType = "Normal",
    MessageType = "Standard",
    Remarks = "Tesztelésbű",
    OrderTransport = "Kamijon"
};

Invoice invoice = new Invoice
{
    InvoiceNumber = "54321",
    RetailerILN = "2111111111222",
    InvoiceCreationDate = DateTime.Now,
    InvoiceCurrency = "HUF",
    PaymentType = "ByCard",
    InvoiceType = "Normal",
    Remarks = "Eskü tesztelésbű",
    TaxAmount = 1200
};

OrderItem singleOrderItem = new OrderItem
{
    EAN = "3211111111222",
    ItemDescription = "Teszt order item 1",
    ItemType = "Normal",
    OrderQuantity = 4,
    UnitOfMeasure = "PCE",
    OrderUnitNetPrice = 640

};

InvoiceItem singleInvoiceItem = new InvoiceItem
{
    EAN = "4321111111222",
    ItemDescription = "Teszt invoice item 1",
    InvoiceQuantity = 6,
    UnitOfMeasure = "PCE",
    InvoiceUnitNetPrice = 640,
    TaxRate = 27,
    TaxCategoryCode = 'S',
    TaxAmount = 700,
    NetAmount = 3800,
    GrossAmount = 4000
};*/

/*singleOrderItem.Order = order;
singleInvoiceItem.Invoice = invoice;*/

/*List<OrderItem> orderItems = new List<OrderItem>();
orderItems.Add(singleOrderItem);

List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
invoiceItems.Add(singleInvoiceItem);

order.OrderItems = orderItems;
invoice.InvoiceItems = invoiceItems;*/

/*order.OrderItems.Add(singleOrderItem);
invoice.InvoiceItems.Add(singleInvoiceItem);*/

//RemovalQuerys.RemoveSupplier(supplier.GLN);
//RemovalQuerys.RemoveRetailer(retailer.GLN);

//InsertionQuerys.InsertSupplier(supplier);
//InsertionQuerys.InsertRetailer(retailer);

var gotSupplier = GetSingleItemQuerys.GetSupplierByGLN("1111111111222");
var gotRetailer = GetSingleItemQuerys.GetRetailerByGLN("2111111111222");
var gotOrder = GetSingleItemQuerys.GetOrderByNumber("12345");
var gotInvoice = GetSingleItemQuerys.GetInvoiceByNumber("54321");

//InsertionQuerys.InsertOrder(order, gotRetailer);
//InsertionQuerys.InsertInvoice(invoice, gotSupplier, gotOrder);
//InsertionQuerys.InsertOrderItem(singleOrderItem, gotOrder);
//InsertionQuerys.InsertInvoiceItem(singleInvoiceItem, gotInvoice);

var orders = GetMultipleItemQuerys.GetOrdersFormConnection(gotRetailer, gotSupplier);
var invoices = GetMultipleItemQuerys.GetInvoicesFromConnection(gotRetailer, gotSupplier);

foreach (var order in orders)
{
    Console.WriteLine(order.OrderNumber);
}
foreach (var invoice in invoices)
{
    Console.WriteLine(invoice.InvoiceNumber);
}

Console.WriteLine("Danone!!");

