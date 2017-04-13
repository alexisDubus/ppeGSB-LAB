<?php
//session_start();
//require('../fpdf.php');

//require_once("../temp/fct.inc.php");
//require_once ("../temp/class.pdogsb.inc.php");
//$pdo = PdoGsb::getPdoGsb(); 

$pdf = new FPDF();
$pdf->AddPage();
$pdf->SetFont('Arial','B',16);
$pdf->Cell(40,10,'Hello World !');
$pdf->Output();
?>
