# IMR-Lab-2

# Tema realizata de:
# Nistor Marian-Sergiu(3B6)
# Pascariu Diana Mihaela(3B6)

Screenshots cu aplicatia:\
https://ibb.co/tKvWPpG \
https://ibb.co/8Mn6NCq \
https://ibb.co/GPCmXp6 \
https://ibb.co/Mhkg0YF

Aplicatia implica o scena in cadrul careia se folosesc elemente caracteristice VR Toolkit.

In fata jucatorului se afla o masa. Pe masa se afla un obiect care va fi folosit spre a desena trail-ul.

Trail-ul este realizat cu ajutorul unui trail renderer, care, by default, are field-ul de "emitting" pe valoarea false.\
Pentru a desena trail-ul, jucatorul trebuie sa ia obiectul in mana(grab), iar apoi trebuie sa il foloseasca(use).\
In momentul in care obiectul respectiv devine "used", trail render-ul trece pe "emitting". Cand devine unused, "emitting" ia din nou valoarea false.\
Key-ul pentru actiunea de "use" este overridden pe tasta "E", in cadrul simulatorului.

Scriptul care face hook-ul catre event-urile de "InteractableObjectUsed" si "InteractableObjectUnused" se afla in Assets/LineDrawScript.cs.
