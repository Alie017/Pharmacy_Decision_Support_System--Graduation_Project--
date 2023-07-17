import React from 'react'
import Layout from '../../../layouts/Layout'
import { useParams } from 'react-router-dom'

export default function Edit() {
  const { id } = useParams()
  
  return (
    <Layout>
      edit doc {id}
    </Layout>
  )
}
