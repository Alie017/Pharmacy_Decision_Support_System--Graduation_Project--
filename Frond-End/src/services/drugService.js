import { api } from './api'

export const getDrugs = () => {
  return api.get('/services/app/Drug/GetListDrug', {
		headers: { Authorization: localStorage.getItem('token') },
	})
}

export const checkInteraction = (barcodes) => {
	return api.post('/services/app/Drug/CheckInteraction', barcodes, {
		headers: { Authorization: localStorage.getItem('token') },
	})
}

export const checkDrugInteraction = barcodes => {
	return api.post('/services/app/Drug/CheckDrugInteraction', barcodes, {
		headers: { Authorization: localStorage.getItem('token') },
	})
}