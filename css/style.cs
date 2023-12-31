* {
  margin: 0 !important;
  padding: 0 !important;
  box-sizing: border-box !important;
  font-family: Arial, Helvetica, sans-serif;
}

ul, ol {
  list-style: none;
}

li {
  margin-bottom: 5px;
}

h1 {
  color: #f0b000;
  font-family: helvetica;
}

h2 {
  color: #f0b000;
  font-family: helvetica;
}

h5 {
  color: #f0b000;
  font-family: helvetica;
}

label {
  color: #f0b000;
  font-family: helvetica;
}

p {
  color: #f0b000;
  font-family: Georgia, "Times New Roman", Times, serif;
}

.fondo {
  background-image: url(../assets/img/fondo.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
}

body {
  height: 100vh;
}

footer {
  height: 15vh;
  width: 100vw;
}

header {
  height: 17vh;
  width: 100vw;
}

.logo:hover {
  opacity: 0.7 !important;
}

.image-zoom {
  transition: 0.3s !important;
}

.image-zoom:hover {
  transform: scale(1.1) !important;
}

.fondo-notices {
  background-color: #ff4500;
  background-image: linear-gradient(62deg, #ff4500 0%, #f0b000 100%);
}

.fondo-foro {
  background-color: #2e2b2a;
  background-image: linear-gradient(62deg, #2e2b2a 0%, #5a5a5a 100%);
}

.btn {
  --bs-btn-padding-x: 0.75rem;
  --bs-btn-padding-y: 0.375rem;
  --bs-btn-font-family: ;
  --bs-btn-font-size: 1rem;
  --bs-btn-font-weight: 400;
  --bs-btn-line-height: 1.5;
  --bs-btn-color: var(--bs-body-color);
  --bs-btn-bg: transparent;
  --bs-btn-border-width: var(--bs-border-width);
  --bs-btn-border-color: transparent;
  --bs-btn-border-radius: var(--bs-border-radius);
  --bs-btn-hover-border-color: transparent;
  --bs-btn-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.15),0 1px 1px rgba(0, 0, 0, 0.075);
  --bs-btn-disabled-opacity: 0.65;
  --bs-btn-focus-box-shadow: 0 0 0 0.25rem rgba(var(--bs-btn-focus-shadow-rgb), .5);
  display: inline-block;
  padding: var(--bs-btn-padding-y) var(--bs-btn-padding-x);
  font-family: var(--bs-btn-font-family);
  font-size: var(--bs-btn-font-size);
  font-weight: var(--bs-btn-font-weight);
  line-height: var(--bs-btn-line-height);
  color: var(--bs-btn-color);
  text-align: center;
  text-decoration: none;
  vertical-align: middle;
  cursor: pointer;
  -webkit-user-select: none;
  -moz-user-select: none;
  user-select: none;
  border: var(--bs-btn-border-width) solid rgba(255, 193, 7, 0);
  border-radius: var(--bs-btn-border-radius);
  background-color: #ffc107;
  transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}

.btn:hover {
  transition: 0.1ms !important;
  background-color: #ff4500 !important;
}

.dropdown-item {
  display: block;
  width: 100%;
  padding: var(--bs-dropdown-item-padding-y) var(--bs-dropdown-item-padding-x);
  clear: both;
  font-weight: 400;
  color: var(--bs-dropdown-link-color);
  text-align: inherit;
  text-decoration: none;
  white-space: nowrap;
  background-color: #ffc107;
  border: 0;
  border-radius: var(--bs-dropdown-item-border-radius, 0);
}

.dropdown-item:hover {
  transition: 0.1ms !important;
  background-color: orangered !important;
}

.btn-item:active {
  transition: 0.1ms !important;
  background-color: orangered !important;
}

.btn-check:checked + .btn, .btn.active, .btn.show, .btn:first-child:active, :not(.btn-check) + .btn:active {
  color: var(--bs-btn-active-color);
  background-color: orangered;
  border-color: var(--bs-btn-active-border-color);
}

.btn-check:checked + .btn, .btn.active, .btn.show, .btn:first-child:active, :not(.btn-check) + .btn:active {
  color: orangered;
  background-color: orangered;
  border-color: orangered;
}

.btn-primary {
  --bs-btn-color: #fff;
  --bs-btn-bg: #ffc107;
  --bs-btn-border-color: #ffc107;
  --bs-btn-hover-color: #fff;
  --bs-btn-hover-bg: #ffc107;
  --bs-btn-hover-border-color: #ffc107;
  --bs-btn-focus-shadow-rgb: 49,132,253;
  --bs-btn-active-color: #fff;
  --bs-btn-active-bg: #ffc107;
  --bs-btn-active-border-color: #ffc107;
  --bs-btn-active-shadow: inset 0 3px 5px orangered;
  --bs-btn-disabled-color: #fff;
  --bs-btn-disabled-bg: #ffc107;
  --bs-btn-disabled-border-color: #ffc107;
}

.btn-close {
  --bs-btn-close-color: #ffc107 !important;
  box-sizing: content-box;
  width: 1em;
  height: 1em;
  padding: 0.25em 0.25em;
  color: #ffc107 !important;
  background: transparent #ffc107 center/1em auto no-repeat !important;
  border: 0;
  border-radius: 0.375rem;
}

.custom-slide {
  background-color: #ffc107;
}

.modal-form {
  display: flex;
  justify-content: center;
}

.accordion {
  display: flex;
  justify-content: start;
  border-bottom: 1px solid white;
}
.accordion .accordion-item {
  margin-left: 30px !important;
  width: 70vw;
  margin-top: 20px !important;
  margin-bottom: 20px !important;
  border-radius: 0 !important;
}

.accordion-button:not(.collapsed) {
  color: black;
  background-color: #f0b000;
  box-shadow: inset 0 calc(-1 * var(--bs-accordion-border-width)) 0 #f0b000;
}

.accordion-button {
  background-color: #f0b000;
}

.accordion-button::after {
  flex-shrink: 0;
  width: var(--bs-accordion-btn-icon-width);
  height: var(--bs-accordion-btn-icon-width);
  margin-left: auto;
  content: "";
  background-image: var(--bs-accordion-btn-icon);
  background-repeat: no-repeat;
  background-size: var(--bs-accordion-btn-icon-width);
  transition: var(--bs-accordion-btn-icon-transition);
}

footer {
  padding: 0 !important;
  margin: 0 !important;
  box-sizing: border-box;
}

header {
  padding: 0 !important;
  margin: 0 !important;
  box-sizing: border-box;
}
header ul {
  padding: 0 !important;
  margin: 0 !important;
  box-sizing: border-box;
}

/*# sourceMappingURL=style.cs.map */
