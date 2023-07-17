import { api } from './api'

export const getAdvices = () => {
  return api.get('/services/app/Opinion/GetListOpinion')
}

export const createAdvice = data => {
  return api.post('/services/app/Opinion/InsertOpinion', data)
}

export const deleteAdvice = id => {
  return api.delete(`/services/app/Opinion/DeleteOpinion?id=${id}`)
}