Personnummerkontrollapplikation
Denna applikation är en C#-konsolapplikation som kontrollerar giltigheten av svenska personnummer. Valideringen sker med regex och Luhn-algoritmen, vilket säkerställer korrekt format och kontrollsiffra. Applikationen är containeriserad med Docker för enkel distribution.

Kör applikationen lokalt
Klona projektet:
bash
Kopiera kod
git clone <repository-url>
cd PersonnummerKontroll
Kör applikationen:
bash
Kopiera kod
dotnet run
Kör applikationen med Docker
Bygg Docker-bild:
bash
Kopiera kod
docker build -t personnummer-kontroll .
Kör containern:
bash
Kopiera kod
docker run -it personnummer-kontroll
GitHub Actions används för CI/CD, vilket inkluderar enhetstester med XUnit och publicering av containern till DockerHub.
