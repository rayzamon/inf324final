<?php
	include 'conexion.php';
	
	$pdo = new Conexion();
	
	//Listar registros y consultar registro
	if($_SERVER['REQUEST_METHOD'] == 'GET')
	{
		if (isset($_GET["Ci"]))
		{
			$sqlp="SELECT * FROM docente where Ci=:Ci";
			$sql = $pdo->prepare($sqlp);
			$sql->bindValue(':Ci', $_GET["Ci"]);
			$sql->execute();
			$sql->setFetchMode(PDO::FETCH_ASSOC);
			echo json_encode($sql->fetchAll());
			header("HTTP/1.1 200 hay datos");		
			exit;		
		}
		else
		{
			$sqlp="SELECT * FROM docente";
			$sql = $pdo->prepare($sqlp);
			$sql->execute();
			$sql->setFetchMode(PDO::FETCH_ASSOC);
			echo json_encode($sql->fetchAll());
			header("HTTP/1.1 200 hay datos");
			exit;		
		}
			
	}
	
	//Insertar registro
	if($_SERVER['REQUEST_METHOD'] == 'POST')
	{
		$sqlp="insert into docente values(:Ci,:Nombre,:Apellido_Paterno,:Apellido_Materno,:Edad)";
		$sql = $pdo->prepare($sqlp);
		$sql->bindValue(':Ci', $_GET["Ci"]);
		$sql->bindValue(':Nombre', $_GET["Nombre"]);
		$sql->bindValue(':Apellido_Paterno', $_GET["Apellido_Paterno"]);
		$sql->bindValue(':Apellido_Materno', $_GET["Apellido_Materno"]);
		$sql->bindValue(':Edad', $_GET["Edad"]);
		$sql->execute();
		echo json_encode('realizado');
		header("HTTP/1.1 200 se incerto correctamente");
		exit;
	}
	//actualizar
	if($_SERVER['REQUEST_METHOD'] == 'PUT')
	{		
		$sqlp="update docente set Nombre=:Nombre,Apellido_Paterno=:Apellido_Paterno,Apellido_Materno=:Apellido_Materno,Edad=:Edad where Ci=:Ci";
		$sql = $pdo->prepare($sqlp);
		$sql->bindValue(':Ci', $_GET["Ci"]);
		$sql->bindValue(':Nombre', $_GET["Nombre"]);
		$sql->bindValue(':Apellido_Paterno', $_GET["Apellido_Paterno"]);
		$sql->bindValue(':Apellido_Materno', $_GET["Apellido_Materno"]);
		$sql->bindValue(':Edad', $_GET["Edad"]);
		
		$sql->execute();
		echo json_encode('realizado');
		header("HTTP/1.1 200 se actualizo correctamente");
		exit;
	}
	//borrar
	if($_SERVER['REQUEST_METHOD'] == 'DELETE')
	{
		$sqlp="delete from docente where Ci=:Ci";
		$sql = $pdo->prepare($sqlp);
		$sql->bindValue(':Ci', $_GET["Ci"]);
		
		$sql->execute();
		echo json_encode('realizado');
		header("HTTP/1.1 200 se actualizo correctamente");
		exit;
	}
	
	header("HTTP/1.1 400 Bad Request");
?>