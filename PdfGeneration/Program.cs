﻿

using PdfGeneration;
using PdfGeneration.Model;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqUE1hXk5Hd0BLVGpAblJ3T2ZQdVt5ZDU7a15RRnVfR1xlSHtXdUBlUH1acg==;Mgo+DSMBPh8sVXJ1S0R+WVpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jTH9Vd0BnWnpYeXdSQQ==;ORg4AjUWIQA/Gnt2VFhiQlRPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXtScERmXXxbdn1QR2I=;MjA3OTUzMkAzMjMxMmUzMjJlMzVDeXB3SGwvT1hhVmhEUWJiQlRrSDBhK0JqMFo5YllYT3VaYUZJTi9ZaUxrPQ==;MjA3OTUzM0AzMjMxMmUzMjJlMzVOeFE3YUpWeG1pTE5oY0luODFiOXBsQklpMHk0Zk5VSFQrdjh6dTk3SFdJPQ==;NRAiBiAaIQQuGjN/V0d+Xk9BfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5Wd0NiXHtddXNVRGhe;MjA3OTUzNUAzMjMxMmUzMjJlMzVQMHQ0cVNDbmdEOGUvOUhkdWNOWllnU3B2UmxlWmI4cTVKOS9Va094TG1BPQ==;MjA3OTUzNkAzMjMxMmUzMjJlMzVVOUZvRjBubE5Xd3VsTTVmY00xeXhBcHVpbjZuVlVlK1cvNUFmVElYc1lNPQ==;Mgo+DSMBMAY9C3t2VFhiQlRPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXtScERmXXxbd3VVQ2I=;MjA3OTUzOEAzMjMxMmUzMjJlMzVpaktKUVk4VDRrVDZkMk9DaXgydkF5OWtGZWthSm1uaml5aDg2SEJrY29BPQ==;MjA3OTUzOUAzMjMxMmUzMjJlMzVwQnF2dHdSTzVRak5tbS90eUFBZGF3Ty9GaUh3MWpBU0xocWVNdmpuaUNBPQ==;MjA3OTU0MEAzMjMxMmUzMjJlMzVQMHQ0cVNDbmdEOGUvOUhkdWNOWllnU3B2UmxlWmI4cTVKOS9Va094TG1BPQ==");

Invoice model = InvoiceDataSource.GetInvoiceDetails();
InvoiceBuilder invoiceBuilder = new InvoiceBuilder(model);
invoiceBuilder.GeneratePDF();