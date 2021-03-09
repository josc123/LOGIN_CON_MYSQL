# LOGIN_CON_MYSQL
Programa haciendo uso de una base de datos creada en MySQL 
Programa haciendo uso de una base de datos creada en MySQL además de un formulario adicional vinculado a una base de datos local (Microsoft Access)

En caso de descargar dicho programa debe de tomarse en consideración ciertos parámetros a cambiar tales como:

1.	Dentro del frmlogin.vb las siguientes líneas de instrucción irán acorde a la base de datos a la que se quiere llegar con sus respectivos parámetros de conexión como son usuario y contraseña donde esta albergada nuestra base de datos
	
Modificar: public sub conectar()

conexion.ConnectionString = "server = direccion del servidor;user=usuario;password=clave;database=nombre de la database "
            conexion.Open()
            PBOFF.Visible = False
            PBON.Visible = True
            TXTCONEXION.Text = ("CONECTADO")

2.	Dentro del Form1.vb las siguientes líneas de instrucción irán acorde a la base de datos a la que se quiere llegar, en este caso se realizó un enlace  con una base de datos en Microsoft Access paro lo cual se deberá tener la dirección donde se encuentra albergada la base de datos dentro de nuestro ordenador 

Modificar: boton1 event click

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pro = "provider= Microsoft.Jet.OLEDB.4.0;Data Source=Provider=Microsoft.Jet.OLEDB.4.0;Data Source= direccion base de datos 
        
