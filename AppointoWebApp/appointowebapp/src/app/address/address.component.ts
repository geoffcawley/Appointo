import { Component, OnInit } from '@angular/core';
import { AddressService } from "./address.service";

@Component({
	selector: 'app-address',
	templateUrl: './address.component.html',
	styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {

	service: AddressService;
	addresses: Addresses;

	constructor(svc: AddressService) {
		this.service = svc;
	}

	ngOnInit() {
		// this.getRooms();
	}

	getAddresses() {
		//		var res: Promise<Rooms> = this.service.getRooms();
		var res: any = this.service.getAddresses();

		res.then(
			(r: any) => {
				this.addresses = r;
				console.log(this.addresses);
				console.log(r);
			},
			(r: any) => {
				console.log(res);
			}
		)

		// this.showResults(this.address);
		this.fillTable(this.addresses);
	}

	showResults(result: Addresses) {
		console.log("Show Results");
		console.log(this.addresses);
		// document.getElementById('result-count').innerHTML = result.length +
		// 	(result.length === 1 ?
		// 		' result' :
		// 		' results');

		// if (result.length > 0) {
		// 	this.fillTable(result);
		// }

		document.getElementById('result-count').innerHTML = this.addresses.length +
			(this.addresses.length === 1 ?
				' result' :
				' results');

		if (this.addresses.length > 0) {
			this.fillTable(this.addresses);
		}
	}

	fillTable(results: Addresses) {
		const target = document.getElementById('result-table');
		const header = document.createElement('thead');
		const headerRow = document.createElement('tr');
		header.appendChild(headerRow);

		for (let key in results[0]) {
			const headerCell = document.createElement('th');
			headerCell.innerText = key;
			headerRow.appendChild(headerCell);
		};
		target.appendChild(header);
		const body = document.createElement('tbody');
		results.forEach((result) => {
			const row = document.createElement('tr');
			for (let key in result) {
				const cell = document.createElement('td');
				cell.innerText = result[key];
				row.appendChild(cell);
			}
			body.appendChild(row);
		});
		target.appendChild(body);
	}

	// addAddress(e: Event, form: FormDataEntryValue) {

	// }

	onSubmit(form: any) {
		console.log('submitted value:', form);
		this.service.addAddress(form.addressLine1, form.addressLine2, 
			form.city, form.state, form.zipCode);
	}
}


export class Address {
	id: number;
	addressLine1: string;
	addressLine2: string;
	city: string;
	state: string;
	zipCode: string;
}

type Addresses = Array<Address>;