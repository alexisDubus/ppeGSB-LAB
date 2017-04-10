<?php
/**
 * HTML2PDF Librairy - example
 *
 * HTML => PDF convertor
 * distributed under the LGPL License
 *
 * @author      Laurent MINGUET <webmaster@html2pdf.fr>
 *
 * isset($_GET['vuehtml']) is not mandatory
 * it allow to display the result in the HTML format
 */

ob_start();

session_start();
require_once("../../../include/fct.inc.php");
require_once ("../../../include/class.pdogsb.inc.php");
$pdo = PdoGsb::getPdoGsb(); 
?>
<style type="text/css">
<!--
    table.page_header {width: 100%; border: none; background-color: #DDDDFF; border-bottom: solid 1mm #AAAADD; padding: 2mm }
    table.page_footer {width: 100%; border: none; background-color: #DDDDFF; border-top: solid 1mm #AAAADD; padding: 2mm}
    h1 {color: #000033}
    h2 {color: #000055}
    h3 {color: #000077}

    div.niveau
    {
        padding-left: 5mm;
    }
-->
</style>
<page backtop="14mm" backbottom="14mm" backleft="10mm" backright="10mm" style="font-size: 12pt">
    <page_header>
        <table class="page_header">
             <h1>
            <?php 
                $test = "testons ensembleeee";
                echo $test;
            ?>
        </h1>
        <h2>
             <?php 
                $test = "testons ensembleeee";
                echo $test;
            ?>
        </h2>
            <tr>
                <td style="width: 100%; text-align: left">
                    <?php
                        //$date = next($array)
                        //$boutBalise = " title='Sommaire' ";
                        $entete = "fiche de frais du mois de ";
                        $mois = " janvier ";
                        $annee = " 2017 ";
                        echo $entete . $mois . $annee;
                   ?>
                </td>
            </tr>
            
        </table>
    </page_header>
       
    <div class="niveau">

        <bookmark title="bbb" level="aa" ></bookmark>
         <h1>
            <?php 
                $test = "testons ensembleeee";
                echo $test;
            ?>
        </h1>
        <h2>
             <?php 
                $test = "testons ensembleeee";
                echo $test;
            ?>
        </h2>
    </div>
</page>
<?php
    $content = ob_get_clean();

    require_once(dirname(__FILE__).'/../html2pdf.class.php');
    try
    {
        $html2pdf = new HTML2PDF('P', 'A4', 'fr', true, 'UTF-8', 0);
        $html2pdf->writeHTML($content, isset($_GET['vuehtml']));
        $html2pdf->createIndex('Vos fiches de frais du mois', 25, 12, false, true, 1);
        $html2pdf->Output('fichesFrais.pdf');
    }
    catch(HTML2PDF_exception $e) {
        echo $e;
        exit;
    }
