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

/**
 * Implements the SayHello RPC method.
 */
function sayHello(call, callback) {
	console.log(`Received ${JSON.stringify(call, null, 2)}`)
	callback(null, {message: 'Hello ' + call.request.name});
}

function multiHello(call) {
	
	setInterval(
		() => {
			call.write({message: "MultiHello " + call.request.name});
		},
		1000
	);

//	call.end();
}

/**
 * Starts an RPC server that receives requests for the Greeter service at the
 * sample server port
 */
function main() {
	var server = new grpc.Server();
	server.addService(hello_proto.Greeter.service, {SayHello: sayHello});
	server.addService(hello_proto.MultiGreeter.service, {SayHello: multiHello});
	server.bind('0.0.0.0:50051', grpc.ServerCredentials.createInsecure());
	server.start();
}

main();