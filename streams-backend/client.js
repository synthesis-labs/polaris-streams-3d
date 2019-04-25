var PROTO_PATH = __dirname + '/../protos/helloworld.proto';

var grpc = require('grpc');
var protoLoader = require('@grpc/proto-loader');
var packageDefinition = protoLoader.loadSync(
	PROTO_PATH,
	{
		keepCase: true,
		longs: String,
		enums: String,
		defaults: true,
		oneofs: true
	});
var hello_proto = grpc.loadPackageDefinition(packageDefinition).helloworld;

function main() {
	// var client = new hello_proto.Greeter(
	// 	'localhost:50051',
	// 	grpc.credentials.createInsecure()
	// );
	// var user = "Tom";
	// client.sayHello({name: user}, function(err, response) {
	// 	console.log('Greeting:', response.message);
	// });

	var multiclient = new hello_proto.MultiGreeter(
		'localhost:50051',
		grpc.credentials.createInsecure()
	);
	var user = "Many Toms";
	var call = multiclient.SayHello({name: user});
	call.on('data', (response) => {
		console.log(`Got ${JSON.stringify(response, null, 2)}`)
	});
}

main();