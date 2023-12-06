// primer ejercicio con three.js
// crear una geometria teniendo en cuenta el orden de los vértices
var camera, scene, renderer;
var cameraControls;
var clock = new THREE.Clock();
var ambientLight, light;


function init() {
	var canvasWidth = window.innerWidth * 0.9;
	var canvasHeight = window.innerHeight * 0.9;

	// CAMERA

	camera = new THREE.PerspectiveCamera( 45, window.innerWidth / window.innerHeight, 1, 80000 );
	camera.position.set(0,-2,0);
	camera.lookAt(1,0,0);

	// LIGHTS

	light = new THREE.DirectionalLight( 0xFFFFFF, 0.7 );
	light.position.set( 0, 0, 0 );
	light.target.position.set(0, 0, 0);
	light.target.updateMatrixWorld()

	var ambientLight = new THREE.AmbientLight( 0x111111 );

	// RENDERER
	renderer = new THREE.WebGLRenderer( { antialias: true } );
	renderer.setSize( canvasWidth, canvasHeight );
	renderer.setClearColor( 0xE2A4F6, 1.0 );

	renderer.gammaInput = true;
	renderer.gammaOutput = true;

	// Add to DOM
	var container = document.getElementById('container');
	container.appendChild( renderer.domElement );

	// CONTROLS
	cameraControls = new THREE.OrbitControls( camera, renderer.domElement );
	cameraControls.target.set(0, 0, 0);

	// arbol 1
        var migeometria = new THREE.Geometry();
	migeometria.vertices.push( new THREE.Vector3( 0.0, 0.0, 0.0 ) );//0a
	migeometria.vertices.push( new THREE.Vector3( 0.3, 0.0, 0.0 ) );//1b
	migeometria.vertices.push( new THREE.Vector3( 0.3, 0.3, 0.0 ) );//2c
	migeometria.vertices.push( new THREE.Vector3( 0.0, 0.3, 0.0 ) );//3d
	migeometria.vertices.push( new THREE.Vector3( 0.15, 0.15, 0.3 ) );//4



	migeometria.faces.push( new THREE.Face3( 0, 3, 2 ) );
	migeometria.faces.push( new THREE.Face3( 2, 1, 0 ) );

	migeometria.faces.push( new THREE.Face3( 2, 3, 4 ) );
	migeometria.faces.push( new THREE.Face3( 1, 2, 4 ) );
	migeometria.faces.push( new THREE.Face3( 0, 1, 4 ) );
	migeometria.faces.push( new THREE.Face3( 3, 0, 4 ) );
    
    var material = new THREE.MeshBasicMaterial( { color: 0x96EA4C } ); // Material de color rojo
    var miobjeto = new THREE.Mesh (migeometria, material); // Crea el objeto

	// arbol 2
var migeometria1 = new THREE.Geometry();

migeometria1.vertices.push(new THREE.Vector3(0.0, 0.0, -0.2)); //0
migeometria1.vertices.push(new THREE.Vector3(0.3, 0.0, -0.2)); //1
migeometria1.vertices.push(new THREE.Vector3(0.3, 0.3, -0.2)); //2
migeometria1.vertices.push(new THREE.Vector3(0.0, 0.3, -0.2)); //3
migeometria1.vertices.push(new THREE.Vector3(0.15, 0.15, 0.1)); //4

migeometria1.faces.push(new THREE.Face3(0, 3, 2));
migeometria1.faces.push(new THREE.Face3(2, 1, 0));

migeometria1.faces.push(new THREE.Face3(2, 3, 4));
migeometria1.faces.push(new THREE.Face3(1, 2, 4));
migeometria1.faces.push(new THREE.Face3(0, 1, 4));
migeometria1.faces.push(new THREE.Face3(3, 0, 4));

var material1 = new THREE.MeshBasicMaterial({ color: 0x2AB434 });
var miobjeto1 = new THREE.Mesh(migeometria1, material1);

// arbol 3
var migeometria2 = new THREE.Geometry();

migeometria2.vertices.push(new THREE.Vector3(0.0, 0.0, -0.4)); //0
migeometria2.vertices.push(new THREE.Vector3(0.3, 0.0, -0.4)); //1
migeometria2.vertices.push(new THREE.Vector3(0.3, 0.3, -0.4)); //2
migeometria2.vertices.push(new THREE.Vector3(0.0, 0.3, -0.4)); //3
migeometria2.vertices.push(new THREE.Vector3(0.15, 0.15, -0.1)); //4

migeometria2.faces.push(new THREE.Face3(0, 3, 2));
migeometria2.faces.push(new THREE.Face3(2, 1, 0));

migeometria2.faces.push(new THREE.Face3(2, 3, 4));
migeometria2.faces.push(new THREE.Face3(1, 2, 4));
migeometria2.faces.push(new THREE.Face3(0, 1, 4));
migeometria2.faces.push(new THREE.Face3(3, 0, 4));

var material2 = new THREE.MeshBasicMaterial({ color: 0x386904 });
var miobjeto2 = new THREE.Mesh(migeometria2, material2);

	// estrella
var estrellaGeometria = new THREE.Geometry();

estrellaGeometria.vertices.push(new THREE.Vector3(0.15,0.15,0.3)); //0E
estrellaGeometria.vertices.push(new THREE.Vector3(0.2,0.2,0.4));//1F
estrellaGeometria.vertices.push(new THREE.Vector3(0.1, 0.1, 0.4)); //2G
estrellaGeometria.vertices.push(new THREE.Vector3(0.2, 0.1, 0.4)); //3H
estrellaGeometria.vertices.push(new THREE.Vector3(0.1, 0.2, 0.4)); //4I
estrellaGeometria.vertices.push(new THREE.Vector3(0.15, 0.15, 0.5));//5J 


estrellaGeometria.faces.push(new THREE.Face3(0, 1, 4));
estrellaGeometria.faces.push(new THREE.Face3(0, 4, 2));
estrellaGeometria.faces.push(new THREE.Face3(0, 2, 3));
estrellaGeometria.faces.push(new THREE.Face3(0, 3, 1));

estrellaGeometria.faces.push(new THREE.Face3(5, 4, 1));
estrellaGeometria.faces.push(new THREE.Face3(5, 2,4));
estrellaGeometria.faces.push(new THREE.Face3(5, 3, 2));
estrellaGeometria.faces.push(new THREE.Face3(5, 1, 3));

var estrellaMaterial = new THREE.MeshBasicMaterial({ color: 0XFFFF00 }); // Material de color amarillo


var estrella = new THREE.Mesh(estrellaGeometria, estrellaMaterial);
// tronco
var eltronco = new THREE.Geometry();
eltronco.vertices.push( new THREE.Vector3( 0.1, 0.1, -0.4 ) );//0a
eltronco.vertices.push( new THREE.Vector3( 0.1, 0.2, -0.4 ) );//1b
eltronco.vertices.push( new THREE.Vector3( 0.2, 0.2, -0.4 ) );//2c
eltronco.vertices.push( new THREE.Vector3( 0.2, 0.1, -0.4 ) );//3d

eltronco.vertices.push( new THREE.Vector3( 0.1, 0.1, -0.55 ) );//0a
eltronco.vertices.push( new THREE.Vector3( 0.1, 0.2, -0.55 ) );//1b
eltronco.vertices.push( new THREE.Vector3( 0.2, 0.2, -0.55 ) );//2c
eltronco.vertices.push( new THREE.Vector3( 0.2, 0.1, -0.55 ) );//3d



eltronco.faces.push( new THREE.Face3( 2, 6, 5 ) );
eltronco.faces.push( new THREE.Face3( 5, 1, 2 ) );

eltronco.faces.push( new THREE.Face3( 0, 4, 7 ) );
eltronco.faces.push( new THREE.Face3( 7, 3, 0 ) );

eltronco.faces.push( new THREE.Face3( 2, 3, 6 ) );
eltronco.faces.push( new THREE.Face3( 3, 7, 6 ) );

eltronco.faces.push( new THREE.Face3( 1, 5, 4 ) );
eltronco.faces.push( new THREE.Face3( 4, 0, 1 ) );

eltronco.faces.push( new THREE.Face3( 6, 7, 4 ) );
eltronco.faces.push( new THREE.Face3( 4, 5, 6 ) );


var materialtr = new THREE.MeshBasicMaterial( { color: 0x9E5502 } ); // Material de color rojo
var miobjetotr = new THREE.Mesh (eltronco, materialtr); // Crea el objeto

// SCENE

scene = new THREE.Scene();
scene.add( light );
scene.add( ambientLight );

	miobjeto.add(estrella); 
	scene.add( miobjeto );
	scene.add( miobjeto1 );
	scene.add( miobjeto2 );
	scene.add(miobjetotr);

	agregarEsfera(0xFF0000, 0.03, new THREE.Vector3(0.03, 0.1, -0.1));//(x,y,z)
	agregarEsfera(0xFF0000, 0.03, new THREE.Vector3(0.0, 0.3, 0.0));//(x,y,z)
	agregarEsfera(0xFF0000, 0.03, new THREE.Vector3(0.21, 0.05, 0.15));//(x,y,z)
	agregarEsfera(0xFF0000, 0.03, new THREE.Vector3(0.3, 0.2, -0.4));//(x,y,z)

	agregarEsfera(0x0000FF, 0.03, new THREE.Vector3(0.27, 0.1, -0.1));
	agregarEsfera(0x0000FF, 0.03, new THREE.Vector3(0.15, -0.031, -0.35));
	agregarEsfera(0x0000FF, 0.03, new THREE.Vector3(0.25, 0.25, 0.15));
	agregarEsfera(0x0000FF, 0.03, new THREE.Vector3(0.15, 0.31, -0.35));//(deiz,adatr,arrab)

	agregarEsfera(0XFFFF00, 0.03, new THREE.Vector3(0.05, 0.1, 0.15));
	agregarEsfera(0XFFFF00, 0.03, new THREE.Vector3(0.1, 0.25, -0.25));
	agregarEsfera(0XFFFF00, 0.03, new THREE.Vector3(0.12, 0.05, -0.1));



}
function agregarEsfera(color, radio, posicion) {
    var geometria = new THREE.SphereGeometry(radio, 32, 32);
    var material = new THREE.MeshBasicMaterial({ color: color });
    var esfera = new THREE.Mesh(geometria, material);
    esfera.position.copy(posicion);
    scene.add(esfera);
}

function animate() {
	window.requestAnimationFrame( animate );
	render();
}

function render() {
	var delta = clock.getDelta();
	cameraControls.update(delta);
	renderer.render( scene, camera );
}

try {
	init();
	animate();
} catch(e) {
	var errorReport = "Your program encountered an unrecoverable error, can not draw on canvas. Error was:<br/><br/>";
	$('#container').append(errorReport+e);
}
