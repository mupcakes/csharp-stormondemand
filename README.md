StormOnDemandAPI
================

C# Library to assist with using the Storm On Demand API.

includes a sample project that uses API IPDetails method defined classes. 
Can easily change the compile output to a library and add the library as a reference to your own project.

Uses Newtonsoft's JSON library, Modified for Liquid Web's Storm API.
Compatible with .Net 4 on Linux and .Net 3.0, 3.5, 4, 4.5 on Windows
When compiling on linux using .NET 4, requires compiler symbol NET35 depending on version of BigInteger.parse() your using.

Can deserialize/serialize Classes, Hashtables, Dictionaries, Objects, Dynamic Objects to and from JSON or XML format.

The APIMethods folder isn't required. It's just a set of helper classes there to make it easier when using an IDE 
with intellisense to remember the methods along with the commenting that will display as tooltips for each method.

The APIRequests/APIResponses folders also aren't required.
The other classes are just examples of how you can serialize/deserialize classes
properties->values into valid JSON strings.

Included some basic unit tests for examples.

## Examples 

The following examples show how to build API requests with and without the helper classes or dynamic classes.
Throughout the examples its implied you set the username and password via

Auth.username = user;
Auth.password = password; 

All of the below use the APIMethods helper classes, you can get the same output without using them simply using APIHandler.Post and passing in the method with the object. ie: string result = APIHandler.Post( "/Storm/Config/list", $OBJECT);

#### Serializing Dictionaries or Hashtables into a JSON API request

	// Storm/Config/list example

	Dictionary<string, dynamic> configList = new Dictionary<string, dynamic>();
	configList.Add ("category", "storm");

	// Returns a JSON string
	Console.WriteLine( APIMethods.Storm.Config.List( configList ));

#### Using a defined class object to serialize into a JSON API request

	public class StormConfigList
	{
		public string category { get; set; }
	}

	StormConfigList stormConfig = new StormConfigList();
	stormConfig.category = "storm";

	// Returns a JSON string
	string result = APIMethods.Storm.Config.List( stormConfig );

#### Storing API responses into a class object

	// Examples using classes for the APIRequest and one to store the APIResponse

	public class IPDetailsRequest
	{
		public string uniq_id { get; set; }
		public string ip { get; set; }
	}

	public class IPDetailsResponse
	{
		public string broadcast { get; set; }
		public string gateway{ get; set; }
		public string ip { get; set; }
		public string netmask { get; set; }
		public string id { get; set; }
	}

	IPDetailsRequest req = new IPDetailsRequest();
	req.uniq_id = "ABCDEF";
	req.ip = "123.45.67.89";

	// Builds JSON from IPDetailsRequest and stores the response from the API in the APIResponse object
	IPDetailsResponse res = JsonConvert.DeserializeObject<IPDetailsResponse>( APIMethods.Network.IP.Details( req ));
	
	// Can access members of the object as any other class
	Console.WriteLine( res.ip ) ;

#### Storing API responses into a Dictionary or Hashtable

	// using a APIRequest
        public class IPDetailsRequest
        {
                public string uniq_id { get; set; }
                public string ip { get; set; }
        }

	IPDetailsRequest req = new IPDetailsRequest();
	req.uniq_id = "ABCDEF";
	req.ip = "123.45.67.89";
	
	// Storing as a Dictionary
	Dictionary<string, dynamic> res = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(APIMethods.Network.IP.Details (req));
	
	// Storing as a Hashtable
	Hashtable res = JsonConvert.DeserializeObject<Hashtable>(APIMethods.Network.IP.Details (req));

	// Can access elements with key names if using a Dictioary such as
	Console.WriteLine ( res["gateway"]);

	// Looping through Dictionary structures
	foreach (KeyValuePair<string,dynamic> en in res) {
			if (en.Key == "gateway")
			Console.WriteLine ( en.Value );
			}

	// Looping through Hashtables structures
	foreach (DictionaryEntry en in res) {
			if (en.Key == "gateway")
			Console.WriteLine( en.value.ToString() );
			}

