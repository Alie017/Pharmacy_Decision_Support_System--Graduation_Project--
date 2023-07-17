import { api } from './api'

export const getDocumentations = () => {
  return api.get(`/services/app/Document/GetListDocument`)
}

export const createDocumentation = data => {
  return api.post('/services/app/Document/InsertDocument', data)
}

export const deleteDocumentation = id => {
  return api.delete(`services/app/Document/DeleteDocument?id=${id}`)
}