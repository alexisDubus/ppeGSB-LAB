<?php 
foreach($_REQUEST['message'] as $message)
	{
      echo "<script language=\"javascript\">";
	  echo "alert ('$message')";
	  echo "</script>";;
	}
?>
