function verificarContra (contra1 , contra2)
{
    
    
    if(contra1 == contra2)
    {
        return true;
    }

    else
    {
        return false;
    }
}
function validarContra(contra) {
    // Requerir al menos 8 caracteres
    
    if (contra.length < 7) {
      return false;
    }
    else if (!/[^a-zA-Z0-9]/.test(contra)) {
        return false;
      } else if (!/[A-Z]/.test(contra)) {
        return false;
      } else
      {        
        return true;
      }
  
    
  }

  function puedoHacerSubmit()
  {
    
    contra1= document.getElementById("contraseña1").value;    
    contra2=document.getElementById("contraseña2").value;
    
    if (validarContra(contra1)==false)
    {
        alert("La contraseña no es segura");   
        return false;
    }
    if (verificarContra(contra1,contra2)==false)
    {
        alert("Las contraseñas no son iguales");   
        return false;
    }
    return true;
     

  }